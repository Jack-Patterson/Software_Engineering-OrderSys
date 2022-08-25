using OrderSys.frmSuppliers;
using System;
using System.Windows.Forms;

namespace OrderSys
{
    public partial class frmRegSup : Form
    {
        public frmRegSup()
        {
            InitializeComponent();
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

            supplier.registerSupplier();

            // Show confirmation message
            MessageBox.Show("Success. Company has been registered to database..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear/Reset UI
            txtName.Clear();
            txtEir.Clear();
            txtStreet.Clear();
            txtTown.Clear();
            txtCounty.Clear();
            txtCompContact.Clear();
            txtEmail.Clear();
            txtPhoneNo.Clear();

            txtSuppID.Text = Supplier.getNextSuppID().ToString("0000");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRegisterSupplier_Load(object sender, EventArgs e)
        {
            txtSuppID.Text = Supplier.getNextSuppID().ToString("0000");
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
    }
}

