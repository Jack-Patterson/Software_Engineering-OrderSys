
namespace OrderSys
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuSuppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupReg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupUpd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddProd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdProd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiscProd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrdPlace = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrdInvPay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOrdLisOstPay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearRevAnaly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearSupAnaly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgPlaceholder = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlaceholder)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSuppliers,
            this.mnuProduct,
            this.mnuOrd,
            this.mnuAdmin,
            this.mnuExit});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(1264, 24);
            this.mnuMainMenu.TabIndex = 1;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuSuppliers
            // 
            this.mnuSuppliers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSupReg,
            this.mnuSupUpd});
            this.mnuSuppliers.Name = "mnuSuppliers";
            this.mnuSuppliers.Size = new System.Drawing.Size(67, 20);
            this.mnuSuppliers.Text = "Suppliers";
            // 
            // mnuSupReg
            // 
            this.mnuSupReg.Name = "mnuSupReg";
            this.mnuSupReg.Size = new System.Drawing.Size(162, 22);
            this.mnuSupReg.Text = "Register Supplier";
            this.mnuSupReg.Click += new System.EventHandler(this.mnuSupReg_Click);
            // 
            // mnuSupUpd
            // 
            this.mnuSupUpd.Name = "mnuSupUpd";
            this.mnuSupUpd.Size = new System.Drawing.Size(162, 22);
            this.mnuSupUpd.Text = "Update Supplier";
            this.mnuSupUpd.Click += new System.EventHandler(this.mnuSupUpd_Click);
            // 
            // mnuProduct
            // 
            this.mnuProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddProd,
            this.mnuUpdProd,
            this.mnuDiscProd});
            this.mnuProduct.Name = "mnuProduct";
            this.mnuProduct.Size = new System.Drawing.Size(66, 20);
            this.mnuProduct.Text = "Products";
            // 
            // mnuAddProd
            // 
            this.mnuAddProd.Name = "mnuAddProd";
            this.mnuAddProd.Size = new System.Drawing.Size(182, 22);
            this.mnuAddProd.Text = "Add Product";
            this.mnuAddProd.Click += new System.EventHandler(this.mnuAddProd_Click);
            // 
            // mnuUpdProd
            // 
            this.mnuUpdProd.Name = "mnuUpdProd";
            this.mnuUpdProd.Size = new System.Drawing.Size(182, 22);
            this.mnuUpdProd.Text = "Update Product";
            this.mnuUpdProd.Click += new System.EventHandler(this.mnuUpdProd_Click);
            // 
            // mnuDiscProd
            // 
            this.mnuDiscProd.Name = "mnuDiscProd";
            this.mnuDiscProd.Size = new System.Drawing.Size(182, 22);
            this.mnuDiscProd.Text = "Discontinue Product";
            this.mnuDiscProd.Click += new System.EventHandler(this.mnuDiscProd_Click);
            // 
            // mnuOrd
            // 
            this.mnuOrd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOrdPlace,
            this.mnuOrdInvPay,
            this.mnuOrdLisOstPay});
            this.mnuOrd.Name = "mnuOrd";
            this.mnuOrd.Size = new System.Drawing.Size(54, 20);
            this.mnuOrd.Text = "Orders";
            // 
            // mnuOrdPlace
            // 
            this.mnuOrdPlace.Name = "mnuOrdPlace";
            this.mnuOrdPlace.Size = new System.Drawing.Size(216, 22);
            this.mnuOrdPlace.Text = "Place Order";
            this.mnuOrdPlace.Click += new System.EventHandler(this.mnuOrdPlace_Click);
            // 
            // mnuOrdInvPay
            // 
            this.mnuOrdInvPay.Name = "mnuOrdInvPay";
            this.mnuOrdInvPay.Size = new System.Drawing.Size(216, 22);
            this.mnuOrdInvPay.Text = "Pay Invoice";
            this.mnuOrdInvPay.Click += new System.EventHandler(this.mnuOrdInvPay_Click);
            // 
            // mnuOrdLisOstPay
            // 
            this.mnuOrdLisOstPay.Name = "mnuOrdLisOstPay";
            this.mnuOrdLisOstPay.Size = new System.Drawing.Size(216, 22);
            this.mnuOrdLisOstPay.Text = "List Outstanding Payments";
            this.mnuOrdLisOstPay.Click += new System.EventHandler(this.mnuOrdLisOstPay_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearRevAnaly,
            this.mnuYearSupAnaly});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuYearRevAnaly
            // 
            this.mnuYearRevAnaly.Name = "mnuYearRevAnaly";
            this.mnuYearRevAnaly.Size = new System.Drawing.Size(199, 22);
            this.mnuYearRevAnaly.Text = "Yearly Revenue Analysis";
            this.mnuYearRevAnaly.Click += new System.EventHandler(this.mnuYearRevAnaly_Click);
            // 
            // mnuYearSupAnaly
            // 
            this.mnuYearSupAnaly.Name = "mnuYearSupAnaly";
            this.mnuYearSupAnaly.Size = new System.Drawing.Size(199, 22);
            this.mnuYearSupAnaly.Text = "Yearly Supplier Analysis";
            this.mnuYearSupAnaly.Click += new System.EventHandler(this.mnuYearSupAnaly_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // imgPlaceholder
            // 
            this.imgPlaceholder.Image = ((System.Drawing.Image)(resources.GetObject("imgPlaceholder.Image")));
            this.imgPlaceholder.Location = new System.Drawing.Point(0, 27);
            this.imgPlaceholder.Name = "imgPlaceholder";
            this.imgPlaceholder.Size = new System.Drawing.Size(1280, 720);
            this.imgPlaceholder.TabIndex = 2;
            this.imgPlaceholder.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.imgPlaceholder);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmMainMenu";
            this.Text = "OrderSys - Main Menu";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlaceholder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuSuppliers;
        private System.Windows.Forms.ToolStripMenuItem mnuSupReg;
        private System.Windows.Forms.ToolStripMenuItem mnuSupUpd;
        private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuAddProd;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdProd;
        private System.Windows.Forms.ToolStripMenuItem mnuDiscProd;
        private System.Windows.Forms.ToolStripMenuItem mnuOrd;
        private System.Windows.Forms.ToolStripMenuItem mnuOrdPlace;
        private System.Windows.Forms.ToolStripMenuItem mnuOrdInvPay;
        private System.Windows.Forms.ToolStripMenuItem mnuOrdLisOstPay;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuYearRevAnaly;
        private System.Windows.Forms.ToolStripMenuItem mnuYearSupAnaly;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgPlaceholder;
    }
}

