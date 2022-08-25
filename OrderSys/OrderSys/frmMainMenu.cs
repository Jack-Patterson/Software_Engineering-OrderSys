using System;
using System.Windows.Forms;

namespace OrderSys
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuSupReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegSup f = new frmRegSup();
            f.ShowDialog();
            this.Close();
        }

        private void mnuSupUpd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdSup f = new frmUpdSup();
            f.ShowDialog();
            this.Close();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAddProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddProd f = new frmAddProd();
            f.ShowDialog();
            this.Dispose();
        }

        private void mnuUpdProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdProd f = new frmUpdProd();
            f.ShowDialog();
            this.Dispose();
        }

        private void mnuDiscProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiscProd f = new frmDiscProd();
            f.ShowDialog();
            this.Dispose();
        }

        private void mnuOrdPlace_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrdPlace f = new frmOrdPlace();
            f.ShowDialog();
            this.Dispose();
        }

        private void mnuOrdInvPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrdInvPay f = new frmOrdInvPay();
            f.Enabled = true;
            f.ShowDialog();
            this.Dispose();
        }

        private void mnuOrdLisOstPay_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOrdLisOstPay f = new frmOrdLisOstPay();
            f.ShowDialog();
            this.Dispose();
        }

        private void mnuYearRevAnaly_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearRevAnaly f = new frmYearRevAnaly();
            f.ShowDialog();
            this.Dispose();
        }

        private void mnuYearSupAnaly_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmYearSupAnaly f = new frmYearSupAnaly();
            f.ShowDialog();
            this.Dispose();
        }
    }
}
