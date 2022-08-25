
namespace OrderSys
{
    partial class frmUpdProd
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
            this.grpSelSupp = new System.Windows.Forms.GroupBox();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.grpSelProd = new System.Windows.Forms.GroupBox();
            this.grpUpdProd = new System.Windows.Forms.GroupBox();
            this.txtSuppID = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpd = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuRegSupplier.SuspendLayout();
            this.grpSelSupp.SuspendLayout();
            this.grpSelProd.SuspendLayout();
            this.grpUpdProd.SuspendLayout();
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
            // grpSelSupp
            // 
            this.grpSelSupp.Controls.Add(this.lstSuppliers);
            this.grpSelSupp.Location = new System.Drawing.Point(38, 41);
            this.grpSelSupp.Name = "grpSelSupp";
            this.grpSelSupp.Size = new System.Drawing.Size(255, 176);
            this.grpSelSupp.TabIndex = 2;
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
            // grpSelProd
            // 
            this.grpSelProd.Controls.Add(this.lstProducts);
            this.grpSelProd.Location = new System.Drawing.Point(38, 241);
            this.grpSelProd.Name = "grpSelProd";
            this.grpSelProd.Size = new System.Drawing.Size(255, 173);
            this.grpSelProd.TabIndex = 3;
            this.grpSelProd.TabStop = false;
            this.grpSelProd.Text = "Select a Product";
            // 
            // grpUpdProd
            // 
            this.grpUpdProd.Controls.Add(this.txtSuppID);
            this.grpUpdProd.Controls.Add(this.txtQty);
            this.grpUpdProd.Controls.Add(this.label4);
            this.grpUpdProd.Controls.Add(this.label3);
            this.grpUpdProd.Controls.Add(this.txtProdID);
            this.grpUpdProd.Controls.Add(this.label5);
            this.grpUpdProd.Controls.Add(this.btnUpd);
            this.grpUpdProd.Controls.Add(this.txtPrice);
            this.grpUpdProd.Controls.Add(this.label2);
            this.grpUpdProd.Controls.Add(this.txtName);
            this.grpUpdProd.Controls.Add(this.label1);
            this.grpUpdProd.Location = new System.Drawing.Point(370, 41);
            this.grpUpdProd.Name = "grpUpdProd";
            this.grpUpdProd.Size = new System.Drawing.Size(428, 246);
            this.grpUpdProd.TabIndex = 4;
            this.grpUpdProd.TabStop = false;
            this.grpUpdProd.Text = "Update a Product";
            // 
            // txtSuppID
            // 
            this.txtSuppID.Enabled = false;
            this.txtSuppID.Location = new System.Drawing.Point(146, 149);
            this.txtSuppID.MaxLength = 99;
            this.txtSuppID.Name = "txtSuppID";
            this.txtSuppID.Size = new System.Drawing.Size(55, 23);
            this.txtSuppID.TabIndex = 16;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(146, 120);
            this.txtQty.MaxLength = 99;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(55, 23);
            this.txtQty.TabIndex = 14;
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
            this.txtProdID.TabIndex = 11;
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
            // btnUpd
            // 
            this.btnUpd.ForeColor = System.Drawing.Color.Black;
            this.btnUpd.Location = new System.Drawing.Point(102, 192);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(144, 23);
            this.btnUpd.TabIndex = 9;
            this.btnUpd.Text = "Update";
            this.btnUpd.UseVisualStyleBackColor = true;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(146, 94);
            this.txtPrice.MaxLength = 99;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(55, 23);
            this.txtPrice.TabIndex = 2;
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
            this.txtName.Location = new System.Drawing.Point(146, 66);
            this.txtName.MaxLength = 99;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 23);
            this.txtName.TabIndex = 1;
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
            // frmUpdProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grpUpdProd);
            this.Controls.Add(this.grpSelProd);
            this.Controls.Add(this.grpSelSupp);
            this.Controls.Add(this.mnuRegSupplier);
            this.MainMenuStrip = this.mnuRegSupplier;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmUpdProd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "OrderSys - Update Product";
            this.Load += new System.EventHandler(this.frmRegisterSupplier_Load);
            this.mnuRegSupplier.ResumeLayout(false);
            this.mnuRegSupplier.PerformLayout();
            this.grpSelSupp.ResumeLayout(false);
            this.grpSelProd.ResumeLayout(false);
            this.grpUpdProd.ResumeLayout(false);
            this.grpUpdProd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuRegSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSelSupp;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.GroupBox grpSelProd;
        private System.Windows.Forms.GroupBox grpUpdProd;
        private System.Windows.Forms.TextBox txtSuppID;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpd;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}