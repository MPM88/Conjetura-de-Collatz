using System;
using System.Windows.Forms;
using System.Numerics;
using System.Threading;

namespace ConjeturaDeCollatz
{
	public partial class FrmMain : Form
	{
		private delegate void UpdateListDelegate(string Value);

		private void UpdateList(string Value)
		{
			if (LBResults.InvokeRequired)
			{
				LBResults.Invoke(new UpdateListDelegate(UpdateList), Value);
			}
			else
			{
				LBResults.Items.Add(Value);
			}
		}
		private void CalculateCollatz(string Number)
		{
			BigInteger MyNumber;
			BigInteger.TryParse(Number, out MyNumber);
			while (MyNumber > 1)
			{
				if (MyNumber.IsEven == false)
				{
					MyNumber = MyNumber * 3 + 1;
					UpdateList(MyNumber.ToString());
				}
				else
				{
					MyNumber = MyNumber / 2;
					UpdateList(MyNumber.ToString());
				}
			}
		}
		private void RunWork(string Number)
		{
			Thread DoWork = new Thread(new ThreadStart(() => CalculateCollatz(Number)));
			DoWork.Start();
		}
		public FrmMain()
		{
			InitializeComponent();
		}

		private void BtnStart_Click(object sender, EventArgs e)
		{
			LBResults.Items.Clear();
			RunWork(TxtNumberIn.Text);

		}
	}
}
