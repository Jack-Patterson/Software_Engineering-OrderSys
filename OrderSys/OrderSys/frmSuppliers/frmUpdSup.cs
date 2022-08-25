using System;
using System.Data;
using System.Windows.Forms;
using OrderSys.frmSuppliers;

namespace OrderSys
{
    public partial class frmUpdSup : Form
    {
        public frmUpdSup()
        {
            InitializeComponent();

            grpUpdDetails.Hide();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateSupplier.validName(txtName.Text))
            {
                MessageBox.Show("Please enter a valid Supplier Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (!ValidateSupplier.validAddress(txtStreet.Text))
            {
                MessageBox.Show("Please enter a valid Street", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return;
            }

            if (!ValidateSupplier.validAddress(txtTown.Text))
            {
                MessageBox.Show("Please enter a valid Town", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                return;
            }

            if (!ValidateSupplier.validCounty(txtCounty.Text))
            {
                MessageBox.Show("Please enter a valid County", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                return;
            }

            if (!ValidateSupplier.validEirCode(txtEir.Text))
            {
                MessageBox.Show("Please enter a valid EirCode", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEir.Focus();
                return;
            }

            if (!ValidateSupplier.validContact(txtCompContact.Text))
            {
                MessageBox.Show("Please enter a valid Company Contact", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCompContact.Focus();
                return;
            }

            if (!ValidateSupplier.validEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter a valid Email", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (!ValidateSupplier.validPhoneNo(txtPhoneNo.Text))
            {
                MessageBox.Show("Please enter a valid Phone Number", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;
            }

            // Save data in DB
            Supplier supplier = new Supplier(Convert.ToInt32(txtSuppID.Text), txtName.Text.ToUpper(), txtEir.Text, txtStreet.Text, txtTown.Text, txtCounty.Text, txtEmail.Text, txtPhoneNo.Text, txtCompContact.Text);

            supplier.UpdateSupplier();

            MessageBox.Show("Success. Company has been updated in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtSuppName.Focus();

            grpUpdDetails.Hide();
            lstSuppliers.Items.Clear();
            txtSuppName.Clear();
            txtName.Clear();
            txtEir.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            txtCompContact.Clear();
            txtEmail.Clear();
            txtPhoneNo.Clear();

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmUpdSupplier_Load(object sender, EventArgs e)
        {
            txtSuppName.Focus();
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu f1 = new frmMainMenu();
            f1.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            DataSet ds = Supplier.searchSuppName(txtSuppName.Text.ToUpper());

            lstSuppliers.Items.Clear();

            for (int i = 0; i < ds.Tables["SUPP"].Rows.Count; i++)
            {
                lstSuppliers.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(4, '0') + " " +
                ds.Tables[0].Rows[i][1]);
            }
        }

        private void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Supplier.searchAllSuppInfo(Supplier.setSelectedItem(lstSuppliers.SelectedItem.ToString()));

            txtSuppID.Text = ds.Tables[0].Rows[0][0].ToString().PadLeft(4, '0');
            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtStreet.Text = ds.Tables[0].Rows[0][2].ToString();
            txtTown.Text = ds.Tables[0].Rows[0][3].ToString();
            txtCounty.Text = ds.Tables[0].Rows[0][4].ToString();
            txtEir.Text = ds.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
            txtPhoneNo.Text = ds.Tables[0].Rows[0][7].ToString();
            txtCompContact.Text = ds.Tables[0].Rows[0][8].ToString();

            grpUpdDetails.Show();
        }
    }
}
