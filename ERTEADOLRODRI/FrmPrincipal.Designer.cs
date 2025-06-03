namespace ERTEADOLRODRI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMINIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPRESASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPLEADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eRTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINIToolStripMenuItem,
            this.eRTESToolStripMenuItem,
            this.iNFORMESToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDMINIToolStripMenuItem
            // 
            this.aDMINIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eMPRESASToolStripMenuItem,
            this.eMPLEADOSToolStripMenuItem});
            this.aDMINIToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.aDMINIToolStripMenuItem.Name = "aDMINIToolStripMenuItem";
            this.aDMINIToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.aDMINIToolStripMenuItem.Text = "ADMINISTRAR";
            // 
            // eMPRESASToolStripMenuItem
            // 
            this.eMPRESASToolStripMenuItem.Name = "eMPRESASToolStripMenuItem";
            this.eMPRESASToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.eMPRESASToolStripMenuItem.Text = "EMPRESAS";
            this.eMPRESASToolStripMenuItem.Click += new System.EventHandler(this.eMPRESASToolStripMenuItem_Click);
            // 
            // eMPLEADOSToolStripMenuItem
            // 
            this.eMPLEADOSToolStripMenuItem.Name = "eMPLEADOSToolStripMenuItem";
            this.eMPLEADOSToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.eMPLEADOSToolStripMenuItem.Text = "EMPLEADOS";
            this.eMPLEADOSToolStripMenuItem.Click += new System.EventHandler(this.eMPLEADOSToolStripMenuItem_Click);
            // 
            // eRTESToolStripMenuItem
            // 
            this.eRTESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.eRTESToolStripMenuItem.Name = "eRTESToolStripMenuItem";
            this.eRTESToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.eRTESToolStripMenuItem.Text = "ERTES";
            this.eRTESToolStripMenuItem.Click += new System.EventHandler(this.eRTESToolStripMenuItem_Click);
            // 
            // iNFORMESToolStripMenuItem
            // 
            this.iNFORMESToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            this.iNFORMESToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.iNFORMESToolStripMenuItem.Text = "INFORMES";
            this.iNFORMESToolStripMenuItem.Click += new System.EventHandler(this.iNFORMESToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 566);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDMINIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPRESASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPLEADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eRTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}