using OrderSys.frmAdmin;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace OrderSys
{
    public partial class frmYearRevAnaly : Form
    {
        public frmYearRevAnaly()
        {
            InitializeComponent();
        }

        // Method Fetch From DB and create graph

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmRegisterSupplier_Load(object sender, EventArgs e)
        {
            loadYears();
            formatGrid();
        }

        public void loadYears()
        {
            int year = DateTime.Today.Year;
            cboYears.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYears.Items.Clear();
            for (int i = 1; i < 5; i++)
            {
                cboYears.Items.Add(year.ToString());
                year--;
            }

            lblYear.TextAlign = ContentAlignment.MiddleCenter;
        }

        public void formatGrid()
        {
            grdYearlyRev.ColumnCount = 12;
            grdYearlyRev.RowCount = 1;

            for (int i = 0; i < 12; i++)
            {
                grdYearlyRev.Columns[i].Width = 90;
                grdYearlyRev.Columns[i].Name = getMonth(i + 1);
                //add line of code to set amount displayed to zero
            }
            //set column header allignment and font
            foreach (DataGridViewColumn col in grdYearlyRev.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            grdYearlyRev.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //make row header invisible
            grdYearlyRev.RowHeadersVisible = false;
        }

        public String getMonth(int monthNo)
        {
            switch (monthNo)
            {
                case 1: return "JAN";
                case 2: return "FEB";
                case 3: return "MAR";
                case 4: return "APR";
                case 5: return "MAY";
                case 6: return "JUN";
                case 7: return "JUL";
                case 8: return "AUG";
                case 9: return "SEP";
                case 10: return "OCT";
                case 11: return "NOV";
                case 12: return "DEC";
                default: return "";
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

        

        public void loadData()
        {
            //hide data
            lblYear.Visible = false;
            grdYearlyRev.Visible = false;

            //get the revenue data by month for the year selected
            DataSet ds = Admin.getYearlyRevenue(cboYears.Text.Substring(2, 2));

            //if no data found
            if (ds.Tables["ORD"].Rows.Count == 0)
            {
                MessageBox.Show("No data found for year " + cboYears.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboYears.Focus();
                return;
            }

            //put the data in the datagrid
            double smallest = 999.99;
            int smallestMonth = 1;
            double largest = 0;
            int largestMonth = 1;
            grdYearlyRev.Rows[0].Cells[1].Style.ForeColor = Color.Red;

            for (int i = 0; i < ds.Tables["ORD"].Rows.Count; i++)
            {
                grdYearlyRev.CurrentCell = grdYearlyRev.Rows[0].Cells[i];
                grdYearlyRev.CurrentCell.Value = ds.Tables["ORD"].Rows[i][1].ToString();

                if (Convert.ToDouble(ds.Tables["ORD"].Rows[i][1]) < smallest)
                {
                    grdYearlyRev.Rows[0].Cells[smallestMonth - 1].Style.ForeColor = Color.Black;
                    smallest = Convert.ToDouble(ds.Tables["ORD"].Rows[i][1]);
                    smallestMonth = i + 1;
                    grdYearlyRev.Rows[0].Cells[smallestMonth - 1].Style.ForeColor = Color.Red;
                }

                if (Convert.ToDouble(ds.Tables["ORD"].Rows[i][1]) > largest)
                {
                    grdYearlyRev.Rows[0].Cells[largestMonth - 1].Style.ForeColor = Color.Black;
                    largest = Convert.ToDouble(ds.Tables["ORD"].Rows[i][1]);
                    largestMonth = i + 1;
                    grdYearlyRev.Rows[0].Cells[largestMonth - 1].Style.ForeColor = Color.Red;
                }

            }

            //show data
            lblYear.Visible = true;
            grdYearlyRev.Visible = true;

        }

        private void cboYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblYear.Text = "Revenue Analysis " + cboYears.Text;
            loadData();
        }
    }
}
