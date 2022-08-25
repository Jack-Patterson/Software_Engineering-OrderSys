using System;
using System.Windows.Forms;
using OrderSys.frmOrders;
using OrderSys.frmProducts;
using OrderSys.frmSuppliers;
using System.Data;

namespace OrderSys
{
    public partial class frmOrdPlace : Form
    {
        public frmOrdPlace()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmOrdPlace_Load(object sender, EventArgs e)
        {
            txtOrdID.Text = Order.getNextOrdID().ToString("0000");

            grpSelSupp.Hide();
            grpSelProd.Hide();
            grpConfProd.Hide();

            txtTotal.Text = "0.00";
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
            DialogResult dr = MessageBox.Show("Are you sure you wish to select this supplier?", "Supplier Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DataSet ds = Product.searchAllProdName(Product.getID(lstSuppliers.SelectedItem.ToString()));

                lstProducts.Items.Clear();

                for (int i = 0; i < ds.Tables["PROD"].Rows.Count; i++)
                {
                    lstProducts.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(4, '0') + " " +
                    ds.Tables[0].Rows[i][1]);
                }

                grpSelProd.Show();

                grpSelSupp.Enabled = false;

                txtSuppName.Enabled = false;
                btnSearchName.Enabled = false;
            }
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Product.searchAllProdInfo(Product.setSelectedItem(lstProducts.SelectedItem.ToString()));

            txtProdID.Text = ds.Tables[0].Rows[0][0].ToString();
            txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][2].ToString();

            int index;
            if (!isInCart(Convert.ToInt32(txtProdID.Text), out index))
            {
                txtQty.Text = ds.Tables[0].Rows[0][3].ToString();
            }
            else
            {
                lstCart.SetSelected(index, true);
                txtQty.Text = (Convert.ToInt32(ds.Tables[0].Rows[0][3].ToString()) - Convert.ToInt32(Order.getQuantity(lstCart.SelectedItem.ToString()))).ToString();
            }

            grpConfProd.Show();
        }

        private void btnConfirmDetails_Click(object sender, EventArgs e)
        {
            if (!ValidateOrder.validQuantity(txtOrdQty.Text, txtQty.Text, txtProdID.Text))
            {
                MessageBox.Show("Please enter a valid Order Quantity", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrdQty.Focus();
                return;
            }

            btnRemove.Enabled = true;

            int index;

            if (isInCart(Convert.ToInt32(txtProdID.Text), out index))
            {
                lstCart.SetSelected(index, true);
                int item;
                int.TryParse(Order.getQuantity(lstCart.SelectedItem.ToString()), out item);
                int qty;
                int.TryParse(txtOrdQty.Text, out qty);
                item += qty;

                lstCart.Items.Insert(index, txtProdID.Text.ToString().PadLeft(4, '0') + "    " + item.ToString().PadLeft(3, ' ') + "    €" + txtPrice.Text.ToString() + "    " + txtName.Text);
                lstCart.Items.RemoveAt(index + 1);
            }
            else
            {
                lstCart.Items.Add(txtProdID.Text.ToString().PadLeft(4, '0') + "    " + txtOrdQty.Text.ToString().PadLeft(3, ' ') + "    €" + txtPrice.Text.ToString().PadLeft(6, ' ') + "    " + txtName.Text);
            }

            updateCartTotal(Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtOrdQty.Text));

            updateQuantity(Convert.ToInt32(txtQty.Text), Convert.ToInt32(txtOrdQty.Text));


        }

        public void updateCartTotal(decimal amount)
        {
            txtTotal.Text = (Convert.ToDecimal(txtTotal.Text) + amount).ToString("####0.00");

        }

        public void updateQuantity(int qty, int ordQty)
        {
            txtQty.Text = (qty - ordQty).ToString();
        }

        private void txtOrdQty_TextChanged(object sender, EventArgs e)
        {
            if (txtOrdQty.TextLength > 0)
            {
                btnConfirmDetails.Enabled = true;
            }
            else
            {
                btnConfirmDetails.Enabled = false;
            }
        }

        private bool isInCart(int prodID, out int index)
        {
            index = 0;
            try
            {
                lstCart.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException aore)
            {
                return false;
            }
            string item;
            string idStr = "";
            int id = 0;

            for (int i = 0; i < lstCart.Items.Count; i++)
            {
                lstCart.SetSelected(lstCart.SelectedIndex, true);
                item = lstCart.SelectedItem.ToString();
                idStr = Product.getProdID(item);
                int.TryParse(idStr, out id);
                if (prodID == id)
                {
                    index = lstCart.SelectedIndex;
                    return true;
                }
                try
                {
                    lstCart.SelectedIndex++;
                }
                catch (ArgumentOutOfRangeException aore)
                {
                    return false;
                }
            }


            return false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            updateCartTotal(-(Convert.ToInt32(Order.getQuantity(lstCart.SelectedItem.ToString())) * Convert.ToDecimal(Order.getPrice(lstCart.SelectedItem.ToString()))));
            updateQuantity(Convert.ToInt32(txtQty.Text), -Convert.ToInt32(Order.getQuantity(lstCart.SelectedItem.ToString())));
            lstCart.Items.RemoveAt(lstCart.SelectedIndex);
            if (lstCart.Items.Count <= 0)
            {
                btnRemove.Enabled = false;
            }
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            if (lstCart.Items.Count <= 0)
            {
                MessageBox.Show("Please add items to the cart.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Are you sure you wish to confirm this order as it is now?", "Supplier Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Order order = new Order(Convert.ToInt32(txtOrdID.Text), Convert.ToDecimal(txtTotal.Text), Convert.ToInt32(Product.getID(lstSuppliers.SelectedItem.ToString())), 'N');

                order.placeOrder();

                for (int i = 0; i < lstCart.Items.Count; i++)
                {
                    lstCart.SelectedIndex = i;

                    Order.removeQuantity(Product.getProdID(lstCart.SelectedItem.ToString()), Convert.ToInt32(Order.getQuantity(lstCart.SelectedItem.ToString())));
                }

                for (int j = 0; j < lstCart.Items.Count; j++)
                {
                    lstCart.SelectedIndex = j;

                    string item = lstCart.SelectedItem.ToString();
                    int qty = Convert.ToInt32(Order.getQuantity(lstCart.SelectedItem.ToString()));

                    Order.OrderItem orderItem = new Order.OrderItem(Convert.ToInt32(txtOrdID.Text), Convert.ToInt32(Product.getID(lstCart.SelectedItem.ToString())), qty, Convert.ToDecimal(Convert.ToDecimal(Order.getPrice(lstCart.SelectedItem.ToString())) * qty));
                    orderItem.addOrderItem();
                
                }

                txtOrdID.Text = Order.getNextOrdID().ToString("0000");

                grpSelSupp.Hide();
                grpSelProd.Hide();
                grpConfProd.Hide();
                grpSelSupp.Enabled = true;

                lstSuppliers.Items.Clear();
                lstCart.Items.Clear();
                txtTotal.Text = "0.00";
                txtSuppName.Clear();

                txtSuppName.Enabled = true;
                btnSearchName.Enabled = true;
            }
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
        }
    }
}
