using OrderSys.frmOrders;
using OrderSys.frmProducts;
using OrderSys.frmSuppliers;
using System;
using System.Data;
using System.Windows.Forms;

namespace OrderSys
{
    public partial class frmOrdLisOstPay : Form
    {
        public frmOrdLisOstPay()
        {
            InitializeComponent();
        }

        // Method to fetch from DB and list payments here.

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRegisterSupplier_Load(object sender, EventArgs e)
        {
            grpSelSupp.Hide();
            grpListOstPay.Hide();
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
            DataSet ordData = Order.getUnpaidOrder(Product.getID(lstSuppliers.SelectedItem.ToString()));
            int tmp;
            string ordID = "";
            
            for (int i = 0; i < ordData.Tables[0].Rows[i][0].ToString().Length; i++)
            {
                if (int.TryParse(ordData.Tables[0].Rows[i][0].ToString()[i].ToString(), out tmp))
                {
                    ordID += ordData.Tables[0].Rows[i][0].ToString()[i];
                }
                else
                {
                    break;
                }
            }

            DataSet ordItemData = Order.getOrdItemData(Product.getID(lstSuppliers.SelectedItem.ToString()));

            lstInvoices.Items.Clear();

            for (int i = 0; i < ordData.Tables["ORD"].Rows.Count; i++)
            {
                lstInvoices.Items.Add(ordData.Tables[0].Rows[i][0].ToString().PadLeft(4, '0') + " " + Order.getDate(ordID) + " " + ordData.Tables[0].Rows[i][2].ToString().PadLeft(4, '0'));

                for (int j = 0; j < ordItemData.Tables["ORDIT"].Rows.Count; j++)
                {
                    lstInvoices.Items.Add("     - " + ordItemData.Tables[0].Rows[j][1].ToString().PadLeft(4, '0') + " " + Order.getProdName(ordItemData.Tables[0].Rows[j][1].ToString()).ToString().PadRight(30, ' ') + " " + ordItemData.Tables[0].Rows[j][1].ToString().PadLeft(3, ' ') + " " + ordItemData.Tables[0].Rows[j][2].ToString().PadRight(6, ' '));
                }
            }

            grpListOstPay.Show();
            grpSelSupp.Enabled = false;
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            grpListOstPay.Hide();
            lstInvoices.Items.Clear();
            grpSelSupp.Enabled = true;
            grpSelSupp.Hide();
            grpSuppName.Enabled = true;
        }
    }
}
