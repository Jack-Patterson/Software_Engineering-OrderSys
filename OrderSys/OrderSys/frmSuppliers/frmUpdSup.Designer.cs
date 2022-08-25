
namespace OrderSys
{
    partial class frmUpdSup
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
            this.grpUpdDetails = new System.Windows.Forms.GroupBox();
            this.txtCompContact = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSuppID = new System.Windows.Forms.TextBox();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEir = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.grpSelectSup = new System.Windows.Forms.GroupBox();
            this.lstSuppliers = new System.Windows.Forms.ListBox();
            this.grpSuppName = new System.Windows.Forms.GroupBox();
            this.txtSuppName = new System.Windows.Forms.TextBox();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.mnuRegSupplier.SuspendLayout();
            this.grpUpdDetails.SuspendLayout();
            this.grpSelectSup.SuspendLayout();
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
            // grpUpdDetails
            // 
            this.grpUpdDetails.Controls.Add(this.txtCompContact);
            this.grpUpdDetails.Controls.Add(this.label10);
            this.grpUpdDetails.Controls.Add(this.txtCounty);
            this.grpUpdDetails.Controls.Add(this.label11);
            this.grpUpdDetails.Controls.Add(this.txtTown);
            this.grpUpdDetails.Controls.Add(this.label12);
            this.grpUpdDetails.Controls.Add(this.txtStreet);
            this.grpUpdDetails.Controls.Add(this.label13);
            this.grpUpdDetails.Controls.Add(this.txtSuppID);
            this.grpUpdDetails.Controls.Add(this.txtPhoneNo);
            this.grpUpdDetails.Controls.Add(this.label14);
            this.grpUpdDetails.Controls.Add(this.label15);
            this.grpUpdDetails.Controls.Add(this.btnAdd);
            this.grpUpdDetails.Controls.Add(this.txtEmail);
            this.grpUpdDetails.Controls.Add(this.label16);
            this.grpUpdDetails.Controls.Add(this.txtEir);
            this.grpUpdDetails.Controls.Add(this.label17);
            this.grpUpdDetails.Controls.Add(this.txtName);
            this.grpUpdDetails.Controls.Add(this.label18);
            this.grpUpdDetails.Location = new System.Drawing.Point(333, 38);
            this.grpUpdDetails.Name = "grpUpdDetails";
            this.grpUpdDetails.Size = new System.Drawing.Size(402, 348);
            this.grpUpdDetails.TabIndex = 2;
            this.grpUpdDetails.TabStop = false;
            this.grpUpdDetails.Text = "Update Supplier Details";
            // 
            // txtCompContact
            // 
            this.txtCompContact.Location = new System.Drawing.Point(148, 207);
            this.txtCompContact.MaxLength = 99;
            this.txtCompContact.Name = "txtCompContact";
            this.txtCompContact.Size = new System.Drawing.Size(224, 23);
            this.txtCompContact.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Company Contact";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(148, 178);
            this.txtCounty.MaxLength = 99;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(224, 23);
            this.txtCounty.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "County";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(148, 149);
            this.txtTown.MaxLength = 99;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(224, 23);
            this.txtTown.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Town";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(148, 120);
            this.txtStreet.MaxLength = 99;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(224, 23);
            this.txtStreet.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "Street Address";
            // 
            // txtSuppID
            // 
            this.txtSuppID.Enabled = false;
            this.txtSuppID.Location = new System.Drawing.Point(148, 27);
            this.txtSuppID.Name = "txtSuppID";
            this.txtSuppID.Size = new System.Drawing.Size(55, 23);
            this.txtSuppID.TabIndex = 11;
            this.txtSuppID.Text = "12345";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(148, 270);
            this.txtPhoneNo.MaxLength = 10;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(224, 23);
            this.txtPhoneNo.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(73, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 15);
            this.label14.TabIndex = 8;
            this.label14.Text = "Supplier ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(77, 273);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 15);
            this.label15.TabIndex = 7;
            this.label15.Text = "Phone No";
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(101, 312);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(148, 236);
            this.txtEmail.MaxLength = 99;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(224, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(101, 239);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 15);
            this.label16.TabIndex = 4;
            this.label16.Text = "Email";
            // 
            // txtEir
            // 
            this.txtEir.Location = new System.Drawing.Point(148, 91);
            this.txtEir.MaxLength = 99;
            this.txtEir.Name = "txtEir";
            this.txtEir.Size = new System.Drawing.Size(224, 23);
            this.txtEir.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(91, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "Eircode";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 62);
            this.txtName.MaxLength = 99;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 23);
            this.txtName.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(43, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "Company Name";
            // 
            // grpSelectSup
            // 
            this.grpSelectSup.Controls.Add(this.lstSuppliers);
            this.grpSelectSup.Location = new System.Drawing.Point(35, 166);
            this.grpSelectSup.Name = "grpSelectSup";
            this.grpSelectSup.Size = new System.Drawing.Size(197, 272);
            this.grpSelectSup.TabIndex = 0;
            this.grpSelectSup.TabStop = false;
            this.grpSelectSup.Text = "Select a Supplier";
            // 
            // lstSuppliers
            // 
            this.lstSuppliers.FormattingEnabled = true;
            this.lstSuppliers.ItemHeight = 15;
            this.lstSuppliers.Location = new System.Drawing.Point(22, 32);
            this.lstSuppliers.Name = "lstSuppliers";
            this.lstSuppliers.Size = new System.Drawing.Size(144, 214);
            this.lstSuppliers.TabIndex = 10;
            this.lstSuppliers.SelectedIndexChanged += new System.EventHandler(this.lstSuppliers_SelectedIndexChanged);
            // 
            // grpSuppName
            // 
            this.grpSuppName.Controls.Add(this.txtSuppName);
            this.grpSuppName.Controls.Add(this.btnSearchName);
            this.grpSuppName.Location = new System.Drawing.Point(35, 38);
            this.grpSuppName.Name = "grpSuppName";
            this.grpSuppName.Size = new System.Drawing.Size(197, 122);
            this.grpSuppName.TabIndex = 11;
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
            // frmUpdSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grpSuppName);
            this.Controls.Add(this.grpUpdDetails);
            this.Controls.Add(this.grpSelectSup);
            this.Controls.Add(this.mnuRegSupplier);
            this.MainMenuStrip = this.mnuRegSupplier;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmUpdSup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "OrderSys - Update Supplier";
            this.Load += new System.EventHandler(this.frmUpdSupplier_Load);
            this.mnuRegSupplier.ResumeLayout(false);
            this.mnuRegSupplier.PerformLayout();
            this.grpUpdDetails.ResumeLayout(false);
            this.grpUpdDetails.PerformLayout();
            this.grpSelectSup.ResumeLayout(false);
            this.grpSuppName.ResumeLayout(false);
            this.grpSuppName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuRegSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpUpdDetails;
        private System.Windows.Forms.TextBox txtCompContact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSuppID;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEir;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox grpSelectSup;
        private System.Windows.Forms.ListBox lstSuppliers;
        private System.Windows.Forms.GroupBox grpSuppName;
        private System.Windows.Forms.TextBox txtSuppName;
        private System.Windows.Forms.Button btnSearchName;
    }
}