using OrderSys.frmOrders;
using OrderSys.frmProducts;
using OrderSys.frmSuppliers;
using System;
using System.Data;
using System.Windows.Forms;

namespace OrderSys
{
    public partial class frmOrdInvPay : Form
    {
        public frmOrdInvPay()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRegisterSupplier_Load(object sender, EventArgs e)
        {
            grpSelSupp.Hide();
            grpSelectInv.Hide();
            grpOrdData.Hide();
            grpSuppData.Hide();
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

            grpSelSupp.Show();
            grpSuppName.Enabled = false;
        }

        private void lstSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Order.getUnpaidOrder(Product.getID(lstSuppliers.SelectedItem.ToString()));

            lstInvoices.Items.Clear();

            for (int i = 0; i < ds.Tables["ORD"].Rows.Count; i++)
            {
                lstInvoices.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(4, '0') + " " +
                ds.Tables[0].Rows[i][1]);
            }

            grpSelectInv.Show();
            grpSelSupp.Enabled = false;
        }

        private void lstInvoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstInvData.Items.Clear();
            lstSuppData.Items.Clear();

            DataSet ds = Order.getSuppData(Product.getID(lstSuppliers.SelectedItem.ToString()));

            for (int i = 0; i < ds.Tables["SUPP"].Rows.Count; i++)
            {
                lstSuppData.Items.Add("Supplier ID: " + ds.Tables[0].Rows[i][0].ToString());
                lstSuppData.Items.Add("Name: " + ds.Tables[0].Rows[i][1].ToString());
                lstSuppData.Items.Add("Address: " + ds.Tables[0].Rows[i][5].ToString() + ", " + ds.Tables[0].Rows[i][2].ToString() + ", " + ds.Tables[0].Rows[i][3].ToString() + ", " + ds.Tables[0].Rows[i][4].ToString());
                lstSuppData.Items.Add("Supplier ID: " + ds.Tables[0].Rows[i][6].ToString());
                lstSuppData.Items.Add("Phone Number: " + ds.Tables[0].Rows[i][7].ToString());
                lstSuppData.Items.Add("Company Contact: " + ds.Tables[0].Rows[i][8].ToString());
            }

            ds = Order.getOrdItemData(Product.getID(lstInvoices.SelectedItem.ToString()));

            for (int i = 0; i < ds.Tables["ORDIT"].Rows.Count; i++)
            {
                lstInvData.Items.Add(ds.Tables[0].Rows[i][1].ToString().PadLeft(4, '0') + " " + Order.getProdName(ds.Tables[0].Rows[i][1].ToString().PadLeft(4, '0')) + " " + ds.Tables[0].Rows[i][2].ToString().PadLeft(3, ' ') + " " + ds.Tables[0].Rows[i][3].ToString().PadLeft(6, ' '));
            }

            txtTotal.Text = "Total: " + Order.getTotal(Product.getID(lstInvoices.SelectedItem.ToString()));

            grpSuppData.Show();
            grpOrdData.Show();
        }

        private void btnPayInv_Click(object sender, EventArgs e)
        {
            Order.payInvoice(Product.getID(lstInvoices.SelectedItem.ToString()));

            MessageBox.Show("Invoice Paid.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpSuppName.Enabled = true;
            grpSelSupp.Enabled = true;
            grpSelSupp.Hide();
            grpSelectInv.Hide();
            lstInvoices.Items.Clear();
            grpSuppData.Hide();
            lstSuppData.Items.Clear();
            grpOrdData.Hide();
            lstInvData.Hide();
            txtTotal.Text = "Total: ";
        }
    }
}
