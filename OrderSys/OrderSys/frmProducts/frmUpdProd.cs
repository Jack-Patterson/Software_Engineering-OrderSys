using System;
using System.Windows.Forms;
using System.Data;
using OrderSys.frmSuppliers;
using OrderSys.frmProducts;

namespace OrderSys
{
    public partial class frmUpdProd : Form
    {
        public frmUpdProd()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRegisterSupplier_Load(object sender, EventArgs e)
        {
            DataSet ds = Supplier.searchAllSuppName();

            lstSuppliers.Items.Clear();

            for (int i = 0; i < ds.Tables["SUPP"].Rows.Count; i++)
            {
                lstSuppliers.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(4, '0') + " " +
                ds.Tables[0].Rows[i][1]);
            }

            grpSelProd.Hide();
            grpUpdProd.Hide();
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

        private void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Product.searchAllProdName(Product.getID(lstSuppliers.SelectedItem.ToString()));

            lstProducts.Items.Clear();

            for (int i = 0; i < ds.Tables["PROD"].Rows.Count; i++)
            {
                lstProducts.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(4, '0') + " " +
                ds.Tables[0].Rows[i][1]);
            }

            grpSelProd.Show();
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpUpdProd.Show();

            DataSet ds = Product.searchAllProdInfo(Product.setSelectedItem(lstProducts.SelectedItem.ToString()));

            txtProdID.Text = ds.Tables[0].Rows[0][0].ToString().PadLeft(4, '0');
            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][2].ToString();
            txtQty.Text = ds.Tables[0].Rows[0][3].ToString();
            txtSuppID.Text = ds.Tables[0].Rows[0][4].ToString().PadLeft(4, '0');
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct.validName(txtName.Text))
            {
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

            Product product = new Product(Convert.ToInt32(txtProdID.Text), txtName.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtQty.Text), Convert.ToInt32(Product.getID(lstSuppliers.SelectedItem.ToString())), 'A');
            product.updateProd();

            MessageBox.Show("Success. Product has been registered to database..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpSelProd.Hide();
            grpUpdProd.Hide();
            txtName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtProdID.Clear();
            txtSuppID.Clear();
        }
    }
}
