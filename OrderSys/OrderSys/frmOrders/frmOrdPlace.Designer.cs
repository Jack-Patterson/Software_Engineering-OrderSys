
namespace OrderSys
{
    partial class frmOrdPlace
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
            this.txtOrdID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpSelSupp = new System.Windows.Forms.GroupBox();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.grpSelProd = new System.Windows.Forms.GroupBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpConfProd = new System.Windows.Forms.GroupBox();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrdQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfirmDetails = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.grpSuppName = new System.Windows.Forms.GroupBox();
            this.txtSuppName = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.mnuRegSupplier.SuspendLayout();
            this.grpSelSupp.SuspendLayout();
            this.grpSelProd.SuspendLayout();
            this.grpConfProd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpSuppName.SuspendLayout();
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
            // txtOrdID
            // 
            this.txtOrdID.Enabled = false;
            this.txtOrdID.Location = new System.Drawing.Point(101, 43);
            this.txtOrdID.Name = "txtOrdID";
            this.txtOrdID.Size = new System.Drawing.Size(55, 23);
            this.txtOrdID.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "OrderID";
            // 
            // grpSelSupp
            // 
            this.grpSelSupp.Controls.Add(this.lstSuppliers);
            this.grpSelSupp.Location = new System.Drawing.Point(47, 207);
            this.grpSelSupp.Name = "grpSelSupp";
            this.grpSelSupp.Size = new System.Drawing.Size(255, 176);
            this.grpSelSupp.TabIndex = 14;
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
            this.grpSelProd.Location = new System.Drawing.Point(47, 389);
            this.grpSelProd.Name = "grpSelProd";
            this.grpSelProd.Size = new System.Drawing.Size(255, 173);
            this.grpSelProd.TabIndex = 15;
            this.grpSelProd.TabStop = false;
            this.grpSelProd.Text = "Select a Product";
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(120, 95);
            this.txtQty.MaxLength = 99;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(55, 23);
            this.txtQty.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Available Quantity";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(120, 69);
            this.txtPrice.MaxLength = 99;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(55, 23);
            this.txtPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(120, 41);
            this.txtName.MaxLength = 99;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 23);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // grpConfProd
            // 
            this.grpConfProd.Controls.Add(this.txtProdID);
            this.grpConfProd.Controls.Add(this.label3);
            this.grpConfProd.Controls.Add(this.txtQty);
            this.grpConfProd.Controls.Add(this.txtOrdQty);
            this.grpConfProd.Controls.Add(this.label4);
            this.grpConfProd.Controls.Add(this.label7);
            this.grpConfProd.Controls.Add(this.btnConfirmDetails);
            this.grpConfProd.Controls.Add(this.txtPrice);
            this.grpConfProd.Controls.Add(this.label2);
            this.grpConfProd.Controls.Add(this.txtName);
            this.grpConfProd.Controls.Add(this.label1);
            this.grpConfProd.Location = new System.Drawing.Point(350, 46);
            this.grpConfProd.Name = "grpConfProd";
            this.grpConfProd.Size = new System.Drawing.Size(330, 223);
            this.grpConfProd.TabIndex = 16;
            this.grpConfProd.TabStop = false;
            this.grpConfProd.Text = "Enter Order Details";
            // 
            // txtProdID
            // 
            this.txtProdID.Enabled = false;
            this.txtProdID.Location = new System.Drawing.Point(120, 16);
            this.txtProdID.MaxLength = 99;
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.Size = new System.Drawing.Size(55, 23);
            this.txtProdID.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "ProdID";
            // 
            // txtOrdQty
            // 
            this.txtOrdQty.Location = new System.Drawing.Point(120, 137);
            this.txtOrdQty.MaxLength = 3;
            this.txtOrdQty.Name = "txtOrdQty";
            this.txtOrdQty.Size = new System.Drawing.Size(47, 23);
            this.txtOrdQty.TabIndex = 1;
            this.txtOrdQty.TextChanged += new System.EventHandler(this.txtOrdQty_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Order Quantity";
            // 
            // btnConfirmDetails
            // 
            this.btnConfirmDetails.Enabled = false;
            this.btnConfirmDetails.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmDetails.Location = new System.Drawing.Point(90, 177);
            this.btnConfirmDetails.Name = "btnConfirmDetails";
            this.btnConfirmDetails.Size = new System.Drawing.Size(144, 23);
            this.btnConfirmDetails.TabIndex = 9;
            this.btnConfirmDetails.Text = "Confirm";
            this.btnConfirmDetails.UseVisualStyleBackColor = true;
            this.btnConfirmDetails.Click += new System.EventHandler(this.btnConfirmDetails_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConfirmOrder);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lstCart);
            this.groupBox1.Location = new System.Drawing.Point(976, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 226);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shopping Cart";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.Black;
            this.btnConfirmOrder.Location = new System.Drawing.Point(63, 180);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(144, 23);
            this.btnConfirmOrder.TabIndex = 11;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(12, 151);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(58, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(206, 152);
            this.txtTotal.MaxLength = 99;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(55, 23);
            this.txtTotal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(162, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total";
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 15;
            this.lstCart.Location = new System.Drawing.Point(11, 22);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(250, 124);
            this.lstCart.TabIndex = 1;
            // 
            // grpSuppName
            // 
            this.grpSuppName.Controls.Add(this.txtSuppName);
            this.grpSuppName.Controls.Add(this.btnSearchName);
            this.grpSuppName.Location = new System.Drawing.Point(47, 79);
            this.grpSuppName.Name = "grpSuppName";
            this.grpSuppName.Size = new System.Drawing.Size(197, 122);
            this.grpSuppName.TabIndex = 18;
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
            // frmOrdPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grpSuppName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpConfProd);
            this.Controls.Add(this.grpSelProd);
            this.Controls.Add(this.grpSelSupp);
            this.Controls.Add(this.txtOrdID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mnuRegSupplier);
            this.MainMenuStrip = this.mnuRegSupplier;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmOrdPlace";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "OrderSys - Place Order";
            this.Load += new System.EventHandler(this.frmOrdPlace_Load);
            this.mnuRegSupplier.ResumeLayout(false);
            this.mnuRegSupplier.PerformLayout();
            this.grpSelSupp.ResumeLayout(false);
            this.grpSelProd.ResumeLayout(false);
            this.grpConfProd.ResumeLayout(false);
            this.grpConfProd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSuppName.ResumeLayout(false);
            this.grpSuppName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuRegSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtOrdID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpSelSupp;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.GroupBox grpSelProd;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpConfProd;
        private System.Windows.Forms.Button btnConfirmDetails;
        private System.Windows.Forms.TextBox txtOrdQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProdID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.GroupBox grpSuppName;
        private System.Windows.Forms.TextBox txtSuppName;
        private System.Windows.Forms.Button btnSearchName;
    }
}