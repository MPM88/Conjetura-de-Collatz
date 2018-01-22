namespace ConjeturaDeCollatz
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TxtNumberIn = new System.Windows.Forms.TextBox();
            this.LBResults = new System.Windows.Forms.ListBox();
            this.lnlNumberIn = new System.Windows.Forms.Label();
            this.lvlSteps = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.Status1 = new System.Windows.Forms.StatusStrip();
            this.TSLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSteps = new System.Windows.Forms.Label();
            this.Status1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNumberIn
            // 
            this.TxtNumberIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNumberIn.Location = new System.Drawing.Point(12, 25);
            this.TxtNumberIn.Name = "TxtNumberIn";
            this.TxtNumberIn.Size = new System.Drawing.Size(350, 20);
            this.TxtNumberIn.TabIndex = 0;
            // 
            // LBResults
            // 
            this.LBResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LBResults.FormattingEnabled = true;
            this.LBResults.Location = new System.Drawing.Point(12, 68);
            this.LBResults.Name = "LBResults";
            this.LBResults.Size = new System.Drawing.Size(350, 264);
            this.LBResults.TabIndex = 1;
            // 
            // lnlNumberIn
            // 
            this.lnlNumberIn.AutoSize = true;
            this.lnlNumberIn.Location = new System.Drawing.Point(12, 9);
            this.lnlNumberIn.Name = "lnlNumberIn";
            this.lnlNumberIn.Size = new System.Drawing.Size(44, 13);
            this.lnlNumberIn.TabIndex = 2;
            this.lnlNumberIn.Text = "Numero";
            // 
            // lvlSteps
            // 
            this.lvlSteps.AutoSize = true;
            this.lvlSteps.Location = new System.Drawing.Point(12, 52);
            this.lvlSteps.Name = "lvlSteps";
            this.lvlSteps.Size = new System.Drawing.Size(36, 13);
            this.lvlSteps.TabIndex = 3;
            this.lvlSteps.Text = "Pasos";
            // 
            // BtnStart
            // 
            this.BtnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStart.Location = new System.Drawing.Point(287, 336);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Comenzar";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Status1
            // 
            this.Status1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSLbl});
            this.Status1.Location = new System.Drawing.Point(0, 366);
            this.Status1.Name = "Status1";
            this.Status1.Size = new System.Drawing.Size(374, 22);
            this.Status1.TabIndex = 5;
            this.Status1.Text = "statusStrip1";
            // 
            // TSLbl
            // 
            this.TSLbl.Name = "TSLbl";
            this.TSLbl.Size = new System.Drawing.Size(68, 17);
            this.TSLbl.Text = "MDev 2017.";
            // 
            // lblSteps
            // 
            this.lblSteps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSteps.AutoSize = true;
            this.lblSteps.Location = new System.Drawing.Point(12, 345);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(36, 13);
            this.lblSteps.TabIndex = 6;
            this.lblSteps.Text = "Pasos";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.BtnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 388);
            this.Controls.Add(this.lblSteps);
            this.Controls.Add(this.Status1);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.lvlSteps);
            this.Controls.Add(this.lnlNumberIn);
            this.Controls.Add(this.LBResults);
            this.Controls.Add(this.TxtNumberIn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(390, 410);
            this.Name = "FrmMain";
            this.Text = "Conjetura de Collatz";
            this.Status1.ResumeLayout(false);
            this.Status1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumberIn;
        private System.Windows.Forms.ListBox LBResults;
        private System.Windows.Forms.Label lnlNumberIn;
        private System.Windows.Forms.Label lvlSteps;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.StatusStrip Status1;
        private System.Windows.Forms.ToolStripStatusLabel TSLbl;
        private System.Windows.Forms.Label lblSteps;
    }
}

