
namespace OrderSys
{
    partial class frmYearRevAnaly
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
            this.mnuRegSupplier = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.grdYearlyRev = new System.Windows.Forms.DataGridView();
            this.mnuRegSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdYearlyRev)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuRegSupplier
            // 
            this.mnuRegSupplier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.exitToolStripMenuItem});
            this.mnuRegSupplier.Location = new System.Drawing.Point(0, 0);
            this.mnuRegSupplier.Name = "mnuRegSupplier";
            this.mnuRegSupplier.Size = new System.Drawing.Size(1264, 24);
            this.mnuRegSupplier.TabIndex = 1;
            this.mnuRegSupplier.Text = "menuStrip1";
            // 
            // mnuHome
            // 
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(52, 20);
            this.mnuHome.Text = "Home";
            this.mnuHome.Click += new System.EventHandler(this.mnuHome_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cboYears
            // 
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(174, 49);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(121, 23);
            this.cboYears.TabIndex = 2;
            this.cboYears.SelectedIndexChanged += new System.EventHandler(this.cboYears_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(44, 52);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(61, 15);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Show Year";
            // 
            // grdYearlyRev
            // 
            this.grdYearlyRev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdYearlyRev.Location = new System.Drawing.Point(129, 272);
            this.grdYearlyRev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdYearlyRev.Name = "grdYearlyRev";
            this.grdYearlyRev.RowHeadersWidth = 51;
            this.grdYearlyRev.RowTemplate.Height = 29;
            this.grdYearlyRev.Size = new System.Drawing.Size(968, 97);
            this.grdYearlyRev.TabIndex = 4;
            this.grdYearlyRev.Visible = false;
            // 
            // frmYearRevAnaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grdYearlyRev);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboYears);
            this.Controls.Add(this.mnuRegSupplier);
            this.MainMenuStrip = this.mnuRegSupplier;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmYearRevAnaly";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "OrderSys - Yearly Revenue Analysis";
            this.Load += new System.EventHandler(this.frmRegisterSupplier_Load);
            this.mnuRegSupplier.ResumeLayout(false);
            this.mnuRegSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdYearlyRev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuRegSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ComboBox cboYears;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.DataGridView grdYearlyRev;
    }
}