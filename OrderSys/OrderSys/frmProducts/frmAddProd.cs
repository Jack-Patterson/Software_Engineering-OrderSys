using OrderSys.frmProducts;
using System;
using System.Data;
using System.Windows.Forms;
using OrderSys.frmSuppliers;

namespace OrderSys
{
    public partial class frmAddProd : Form
    {
        public frmAddProd()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct.validName(txtName.Text)){
                MessageBox.Show("Please enter a valid Product Name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (!ValidateProduct.validNumber(txtPrice.Text))
            {
                MessageBox.Show("Please enter a valid Price", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            if (!ValidateProduct.validNumber(txtQty.Text))
            {
                MessageBox.Show("Please enter a valid Quantity", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQty.Focus();
                return;
            }

            Product product = new Product(Convert.ToInt32(txtProdID.Text), txtName.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtQty.Text),  Convert.ToInt32(Product.getID(lstSuppliers.SelectedItem.ToString())), 'A');

            product.addProduct();

            // Show confirmation message
            MessageBox.Show("Success. Product has been registered to database..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtProdID.Text = Product.getNextProdID().ToString("0000");

            txtName.Clear();
            txtPrice.Clear();
            txtQty.Clear();

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAddProd_Load(object sender, EventArgs e)
        {
            txtProdID.Text = Product.getNextProdID().ToString("0000");

            DataSet ds = Supplier.searchAllSuppName();

            lstSuppliers.Items.Clear();

            for (int i = 0; i < ds.Tables["SUPP"].Rows.Count; i++)
            {
                lstSuppliers.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(4, '0') + " " +
                ds.Tables[0].Rows[i][1]);
            }
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
