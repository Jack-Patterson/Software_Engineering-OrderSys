
namespace OrderSys
{
    partial class frmDiscProd
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
            this.grpSelSupp = new System.Windows.Forms.GroupBox();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.mnuRegSupplier = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSelProd = new System.Windows.Forms.GroupBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.grpDiscProd = new System.Windows.Forms.GroupBox();
            this.txtSuppID = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDisc = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSelSupp.SuspendLayout();
            this.mnuRegSupplier.SuspendLayout();
            this.grpSelProd.SuspendLayout();
            this.grpDiscProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSelSupp
            // 
            this.grpSelSupp.Controls.Add(this.lstSuppliers);
            this.grpSelSupp.Location = new System.Drawing.Point(35, 38);
            this.grpSelSupp.Name = "grpSelSupp";
            this.grpSelSupp.Size = new System.Drawing.Size(255, 176);
            this.grpSelSupp.TabIndex = 0;
            this.grpSelSupp.TabStop = false;
            this.grpSelSupp.Text = "Select a Supplier";
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.ItemHeight = 15;
            this.lstSuppliers.Location = new System.Drawing.Point(30, 22);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(184, 124);
            this.lstSuppliers.TabIndex = 0;
            this.lstSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstSuppliers_SelectedIndexChanged);
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
            // grpSelProd
            // 
            this.grpSelProd.Controls.Add(this.lstProducts);
            this.grpSelProd.Location = new System.Drawing.Point(35, 230);
            this.grpSelProd.Name = "grpSelProd";
            this.grpSelProd.Size = new System.Drawing.Size(255, 173);
            this.grpSelProd.TabIndex = 2;
            this.grpSelProd.TabStop = false;
            this.grpSelProd.Text = "Select a Product";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 15;
            this.lstProducts.Location = new System.Drawing.Point(30, 22);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(184, 124);
            this.lstProducts.TabIndex = 1;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // grpDiscProd
            // 
            this.grpDiscProd.Controls.Add(this.txtSuppID);
            this.grpDiscProd.Controls.Add(this.txtQty);
            this.grpDiscProd.Controls.Add(this.label4);
            this.grpDiscProd.Controls.Add(this.label3);
            this.grpDiscProd.Controls.Add(this.txtProdID);
            this.grpDiscProd.Controls.Add(this.label5);
            this.grpDiscProd.Controls.Add(this.btnDisc);
            this.grpDiscProd.Controls.Add(this.txtPrice);
            this.grpDiscProd.Controls.Add(this.label2);
            this.grpDiscProd.Controls.Add(this.txtName);
            this.grpDiscProd.Controls.Add(this.label1);
            this.grpDiscProd.Location = new System.Drawing.Point(339, 38);
            this.grpDiscProd.Name = "grpDiscProd";
            this.grpDiscProd.Size = new System.Drawing.Size(428, 246);
            this.grpDiscProd.TabIndex = 3;
            this.grpDiscProd.TabStop = false;
            this.grpDiscProd.Text = "Discontinue a Product";
            // 
            // txtSuppID
            // 
            this.txtSuppID.Enabled = false;
            this.txtSuppID.Location = new System.Drawing.Point(146, 149);
            this.txtSuppID.MaxLength = 99;
            this.txtSuppID.Name = "txtSuppID";
            this.txtSuppID.Size = new System.Drawing.Size(55, 23);
            this.txtSuppID.TabIndex = 6;
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(146, 120);
            this.txtQty.MaxLength = 99;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(55, 23);
            this.txtQty.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Supplier ID";
            // 
            // txtProdID
            // 
            this.txtProdID.Enabled = false;
            this.txtProdID.Location = new System.Drawing.Point(146, 38);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(55, 23);
            this.txtProdID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Product ID";
            // 
            // btnDisc
            // 
            this.btnDisc.ForeColor = System.Drawing.Color.Black;
            this.btnDisc.Location = new System.Drawing.Point(102, 192);
            this.btnDisc.Name = "btnDisc";
            this.btnDisc.Size = new System.Drawing.Size(144, 23);
            this.btnDisc.TabIndex = 7;
            this.btnDisc.Text = "Discontinue";
            this.btnDisc.UseVisualStyleBackColor = true;
            this.btnDisc.Click += new System.EventHandler(this.btnDisc_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(146, 94);
            this.txtPrice.MaxLength = 99;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(55, 23);
            this.txtPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(146, 66);
            this.txtName.MaxLength = 99;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 23);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // frmDiscProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grpDiscProd);
            this.Controls.Add(this.grpSelProd);
            this.Controls.Add(this.grpSelSupp);
            this.Controls.Add(this.mnuRegSupplier);
            this.MainMenuStrip = this.mnuRegSupplier;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmDiscProd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "OrderSys - Discontinue Product";
            this.Load += new System.EventHandler(this.frmRegisterSupplier_Load);
            this.grpSelSupp.ResumeLayout(false);
            this.mnuRegSupplier.ResumeLayout(false);
            this.mnuRegSupplier.PerformLayout();
            this.grpSelProd.ResumeLayout(false);
            this.grpDiscProd.ResumeLayout(false);
            this.grpDiscProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSelSupp;
        private System.Windows.Forms.MenuStrip mnuRegSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.GroupBox grpSelProd;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.GroupBox grpDiscProd;
        private System.Windows.Forms.TextBox txtSuppID;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDisc;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}