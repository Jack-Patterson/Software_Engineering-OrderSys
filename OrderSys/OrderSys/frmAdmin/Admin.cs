using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace OrderSys.frmAdmin
{
    class Admin
    {
        public static DataSet getYearlyRevenue(String Year)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT EXTRACT(MONTH FROM OrderDate), SUM(OrderValue) FROM Orders WHERE OrderDate LIKE '%" +
                Year + "' GROUP BY EXTRACT(MONTH FROM OrderDate) ORDER BY EXTRACT(MONTH FROM OrderDate)";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "ORD");

            conn.Close();

            return ds;

        }

        public static DataSet getYearlySuppRevenue(String Year, string suppID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String strSQL = "SELECT EXTRACT(MONTH FROM OrderDate), SUM(OrderValue) FROM Orders WHERE OrderDate LIKE '%" +
                Year + "' AND SuppID LIKE " + suppID + " GROUP BY EXTRACT(MONTH FROM OrderDate) ORDER BY EXTRACT(MONTH FROM OrderDate)";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "ORD");

            conn.Close();

            return ds;

        }
    }
}
