
namespace OrderSys
{
    partial class frmYearSupAnaly
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
            this.grdYearlyRev = new System.Windows.Forms.DataGridView();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.grpSuppName = new System.Windows.Forms.GroupBox();
            this.txtSuppName = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.grpSelSupp = new System.Windows.Forms.GroupBox();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.mnuRegSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdYearlyRev)).BeginInit();
            this.grpSuppName.SuspendLayout();
            this.grpSelSupp.SuspendLayout();
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
            // grdYearlyRev
            // 
            this.grdYearlyRev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdYearlyRev.Location = new System.Drawing.Point(72, 316);
            this.grdYearlyRev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdYearlyRev.Name = "grdYearlyRev";
            this.grdYearlyRev.RowHeadersWidth = 51;
            this.grdYearlyRev.RowTemplate.Height = 29;
            this.grdYearlyRev.Size = new System.Drawing.Size(968, 97);
            this.grdYearlyRev.TabIndex = 7;
            this.grdYearlyRev.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(25, 52);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(61, 15);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Show Year";
            // 
            // cboYears
            // 
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(162, 49);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(121, 23);
            this.cboYears.TabIndex = 5;
            this.cboYears.SelectedIndexChanged += new System.EventHandler(this.cboYears_SelectedIndexChanged_1);
            // 
            // grpSuppName
            // 
            this.grpSuppName.Controls.Add(this.txtSuppName);
            this.grpSuppName.Controls.Add(this.btnSearchName);
            this.grpSuppName.Location = new System.Drawing.Point(39, 95);
            this.grpSuppName.Name = "grpSuppName";
            this.grpSuppName.Size = new System.Drawing.Size(197, 122);
            this.grpSuppName.TabIndex = 25;
            this.grpSuppName.TabStop = false;
            this.grpSuppName.Text = "Input Supplier Name (or part of)";
            // 
            // txtSuppName
            // 
            this.txtSuppName.Location = new System.Drawing.Point(22, 39);
            this.txtSuppName.MaxLength = 99;
            this.txtSuppName.Name = "txtSuppName";
            this.txtSuppName.Size = new System.Drawing.Size(144, 23);
            this.txtSuppName.TabIndex = 10;
            // 
            // btnSearchName
            // 
            this.btnSearchName.ForeColor = System.Drawing.Color.Black;
            this.btnSearchName.Location = new System.Drawing.Point(22, 83);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(144, 23);
            this.btnSearchName.TabIndex = 9;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // grpSelSupp
            // 
            this.grpSelSupp.Controls.Add(this.lstSuppliers);
            this.grpSelSupp.Location = new System.Drawing.Point(286, 95);
            this.grpSelSupp.Name = "grpSelSupp";
            this.grpSelSupp.Size = new System.Drawing.Size(226, 176);
            this.grpSelSupp.TabIndex = 26;
            this.grpSelSupp.TabStop = false;
            this.grpSelSupp.Text = "Select a Supplier";
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.ItemHeight = 15;
            this.lstSuppliers.Location = new System.Drawing.Point(13, 22);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(184, 124);
            this.lstSuppliers.TabIndex = 0;
            // 
            // frmYearSupAnaly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grpSelSupp);
            this.Controls.Add(this.grpSuppName);
            this.Controls.Add(this.grdYearlyRev);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboYears);
            this.Controls.Add(this.mnuRegSupplier);
            this.MainMenuStrip = this.mnuRegSupplier;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmYearSupAnaly";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "OrderSys - Yearly Supplier Analysis";
            this.Load += new System.EventHandler(this.frmRegisterSupplier_Load);
            this.mnuRegSupplier.ResumeLayout(false);
            this.mnuRegSupplier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdYearlyRev)).EndInit();
            this.grpSuppName.ResumeLayout(false);
            this.grpSuppName.PerformLayout();
            this.grpSelSupp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuRegSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdYearlyRev;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboYears;
        private System.Windows.Forms.GroupBox grpSuppName;
        private System.Windows.Forms.TextBox txtSuppName;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.GroupBox grpSelSupp;
        private System.Windows.Forms.ListBox lstSuppliers;
    }
}