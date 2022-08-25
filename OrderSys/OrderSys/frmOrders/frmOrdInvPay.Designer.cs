
namespace OrderSys
{
    partial class frmOrdInvPay
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
            this.grpSelectInv = new System.Windows.Forms.GroupBox();
            this.lstInvoices = new System.Windows.Forms.ListBox();
            this.mnuRegSupplier = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSuppName = new System.Windows.Forms.GroupBox();
            this.txtSuppName = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.grpSelSupp = new System.Windows.Forms.GroupBox();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.grpSuppData = new System.Windows.Forms.GroupBox();
            this.lstSuppData = new System.Windows.Forms.ListBox();
            this.grpOrdData = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPayInv = new System.Windows.Forms.Button();
            this.lstInvData = new System.Windows.Forms.ListBox();
            this.grpSelectInv.SuspendLayout();
            this.mnuRegSupplier.SuspendLayout();
            this.grpSuppName.SuspendLayout();
            this.grpSelSupp.SuspendLayout();
            this.grpSuppData.SuspendLayout();
            this.grpOrdData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelectInv
            // 
            this.grpSelectInv.Controls.Add(this.lstInvoices);
            this.grpSelectInv.Location = new System.Drawing.Point(12, 349);
            this.grpSelectInv.Name = "grpSelectInv";
            this.grpSelectInv.Size = new System.Drawing.Size(144, 160);
            this.grpSelectInv.TabIndex = 0;
            this.grpSelectInv.TabStop = false;
            this.grpSelectInv.Text = "Select Invoice";
            // 
            // lstInvoices
            // 
            this.lstInvoices.FormattingEnabled = true;
            this.lstInvoices.ItemHeight = 15;
            this.lstInvoices.Location = new System.Drawing.Point(18, 22);
            this.lstInvoices.Name = "lstInvoices";
            this.lstInvoices.Size = new System.Drawing.Size(95, 124);
            this.lstInvoices.TabIndex = 10;
            this.lstInvoices.SelectedIndexChanged += new System.EventHandler(this.lstInvoices_SelectedIndexChanged);
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
            // grpSuppName
            // 
            this.grpSuppName.Controls.Add(this.txtSuppName);
            this.grpSuppName.Controls.Add(this.btnSearchName);
            this.grpSuppName.Location = new System.Drawing.Point(12, 27);
            this.grpSuppName.Name = "grpSuppName";
            this.grpSuppName.Size = new System.Drawing.Size(197, 122);
            this.grpSuppName.TabIndex = 20;
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
            this.grpSelSupp.Location = new System.Drawing.Point(12, 155);
            this.grpSelSupp.Name = "grpSelSupp";
            this.grpSelSupp.Size = new System.Drawing.Size(226, 176);
            this.grpSelSupp.TabIndex = 19;
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
            this.lstSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstSuppliers_SelectedIndexChanged);
            // 
            // grpSuppData
            // 
            this.grpSuppData.Controls.Add(this.lstSuppData);
            this.grpSuppData.Location = new System.Drawing.Point(318, 27);
            this.grpSuppData.Name = "grpSuppData";
            this.grpSuppData.Size = new System.Drawing.Size(470, 176);
            this.grpSuppData.TabIndex = 21;
            this.grpSuppData.TabStop = false;
            this.grpSuppData.Text = "Supplier Data";
            // 
            // lstSuppData
            // 
            this.lstSuppData.Enabled = false;
            this.lstSuppData.FormattingEnabled = true;
            this.lstSuppData.ItemHeight = 15;
            this.lstSuppData.Location = new System.Drawing.Point(13, 22);
            this.lstSuppData.Name = "lstSuppData";
            this.lstSuppData.Size = new System.Drawing.Size(438, 124);
            this.lstSuppData.TabIndex = 0;
            // 
            // grpOrdData
            // 
            this.grpOrdData.Controls.Add(this.txtTotal);
            this.grpOrdData.Controls.Add(this.btnPayInv);
            this.grpOrdData.Controls.Add(this.lstInvData);
            this.grpOrdData.Location = new System.Drawing.Point(318, 225);
            this.grpOrdData.Name = "grpOrdData";
            this.grpOrdData.Size = new System.Drawing.Size(470, 216);
            this.grpOrdData.TabIndex = 22;
            this.grpOrdData.TabStop = false;
            this.grpOrdData.Text = "Invoice Data";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(145, 152);
            this.txtTotal.MaxLength = 99;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(144, 23);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.Text = "Total:";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPayInv
            // 
            this.btnPayInv.ForeColor = System.Drawing.Color.Black;
            this.btnPayInv.Location = new System.Drawing.Point(145, 187);
            this.btnPayInv.Name = "btnPayInv";
            this.btnPayInv.Size = new System.Drawing.Size(144, 23);
            this.btnPayInv.TabIndex = 10;
            this.btnPayInv.Text = "Pay Invoice";
            this.btnPayInv.UseVisualStyleBackColor = true;
            this.btnPayInv.Click += new System.EventHandler(this.btnPayInv_Click);
            // 
            // lstInvData
            // 
            this.lstInvData.Enabled = false;
            this.lstInvData.FormattingEnabled = true;
            this.lstInvData.ItemHeight = 15;
            this.lstInvData.Location = new System.Drawing.Point(13, 22);
            this.lstInvData.Name = "lstInvData";
            this.lstInvData.Size = new System.Drawing.Size(438, 124);
            this.lstInvData.TabIndex = 0;
            // 
            // frmOrdInvPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grpOrdData);
            this.Controls.Add(this.grpSuppData);
            this.Controls.Add(this.grpSuppName);
            this.Controls.Add(this.grpSelSupp);
            this.Controls.Add(this.grpSelectInv);
            this.Controls.Add(this.mnuRegSupplier);
            this.MainMenuStrip = this.mnuRegSupplier;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmOrdInvPay";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "OrderSys - Pay Invoice";
            this.Load += new System.EventHandler(this.frmRegisterSupplier_Load);
            this.grpSelectInv.ResumeLayout(false);
            this.mnuRegSupplier.ResumeLayout(false);
            this.mnuRegSupplier.PerformLayout();
            this.grpSuppName.ResumeLayout(false);
            this.grpSuppName.PerformLayout();
            this.grpSelSupp.ResumeLayout(false);
            this.grpSuppData.ResumeLayout(false);
            this.grpOrdData.ResumeLayout(false);
            this.grpOrdData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelectInv;
        private System.Windows.Forms.MenuStrip mnuRegSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox lstInvoices;
        private System.Windows.Forms.GroupBox grpSuppName;
        private System.Windows.Forms.TextBox txtSuppName;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.GroupBox grpSelSupp;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.GroupBox grpSuppData;
        private System.Windows.Forms.ListBox lstSuppData;
        private System.Windows.Forms.GroupBox grpOrdData;
        private System.Windows.Forms.ListBox lstInvData;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnPayInv;
    }
}