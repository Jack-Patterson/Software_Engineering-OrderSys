using System;
using System.Windows.Forms;
using System.Data;
using OrderSys.frmSuppliers;
using OrderSys.frmProducts;

namespace OrderSys
{
    public partial class frmDiscProd : Form
    {
        public frmDiscProd()
        {
            InitializeComponent();

            grpSelProd.Hide();
            grpDiscProd.Hide();
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

        private void btnSupp_Click(object sender, EventArgs e)
        {
            grpSelProd.Show();
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
            grpDiscProd.Show();

            DataSet ds = Product.searchAllProdInfo(Product.setSelectedItem(lstProducts.SelectedItem.ToString()));

            txtProdID.Text = ds.Tables[0].Rows[0][0].ToString().PadLeft(4, '0');
            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][2].ToString();
            txtQty.Text = ds.Tables[0].Rows[0][3].ToString();
            txtSuppID.Text = ds.Tables[0].Rows[0][4].ToString().PadLeft(4, '0');
        }

        private void btnDisc_Click(object sender, EventArgs e)
        {
            Product.discontinueProd(Convert.ToInt32(txtProdID.Text));

            MessageBox.Show("Success. Product has been discontinued.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpSelProd.Hide();
            grpDiscProd.Hide();

            txtName.Clear();
            txtProdID.Clear();
            txtSuppID.Clear();
            txtPrice.Clear();
            txtQty.Clear();
        }
    }
}
