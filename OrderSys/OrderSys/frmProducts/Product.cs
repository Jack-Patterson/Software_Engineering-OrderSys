using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;
using System.Data;

namespace OrderSys.frmProducts
{
    class Product
    {
        int prodID;
        String name;
        int qty;
        decimal price;
        int suppID;
        char status;

        public Product(int prodID, String name, decimal price, int qty, int suppID, char status)
        {
            setProdID(prodID);
            setName(name);
            setQty(qty);
            setPrice(price);
            setSuppID(suppID);
            setStatus(status);
        }

        public Product()
        {

        }

        public int getProdID()
        {
            return prodID;
        }

        public void setProdID(int prodID)
        {
            this.prodID = prodID;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public int getQty()
        {
            return qty;
        }

        public void setQty(int qty)
        {
            this.qty = qty;
        }

        public decimal getPrice()
        {
            return price;
        }

        public void setPrice(decimal price)
        {
            this.price = price;
        }

        public int getSuppID()
        {
            // return Supplier.getSuppID();

            return suppID;
        }

        public void setSuppID(int suppID)
        {
            // this.suppID = Supplier.getSuppID();

            this.suppID = suppID;
        }

        public char getStatus()
        {
            return status;
        }

        public void setStatus(char status)
        {
            this.status = status;
        }

        public void addProduct()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Products VALUES (" +
            getProdID() + ",'" +
            getName() + "'," +
            getPrice() + "," +
            getQty() + "," +
            getSuppID() + ",'" +
            getStatus() + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public static int getNextProdID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT MAX(ProdID) FROM Products";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            int nextId;

            if (dr.IsDBNull(0))
            {
                nextId = 1;
            }
            else
            {
                nextId = dr.GetInt32(0) + 1;
            }

            conn.Close();

            return nextId;
        }

        public static String getID(String item)
        {
            String itemStr = "";
            for (int i = 0; i < 4; i++)
            {
                itemStr += item[i];
            }

            return itemStr;
        }

        public static String getProdID(String item)
        {
            String itemStr = "";
            for (int i = 0; i < 4; i++)
            {
                itemStr += item[i];
            }

            return itemStr;
        }

        public static string setSelectedItem(String item)
        {
            String selectedItem = "";

            for (int i = 5; i < item.Length; i++)
            {
                selectedItem += item[i];
            }

            return selectedItem;
        }

        public static DataSet searchAllProdName(string suppID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT ProdID,Name FROM Products WHERE SuppID LIKE " + suppID + " AND Status = 'A' ORDER BY Name";

            DataSet ds = new DataSet();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "PROD");
            conn.Close();

            return ds;
        }

        public static DataSet searchAllProdInfo(String searchItem)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Products WHERE Name LIKE '" + searchItem + "'";

            DataSet ds = new DataSet();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "SUPP");
            conn.Close();

            return ds;
        }

        public static void discontinueProd(int prodID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Products SET " +
            "Status = 'D' " +
            "WHERE ProdID = " + prodID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void updateProd()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Products SET " +
            "Name = '" + getName() + "', " +
            "Price = " + getPrice() + ", " +
            "Qty = " + getQty() +
            " WHERE ProdID = " + getProdID();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static int searchProdQty(String searchItem)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT Qty FROM Products WHERE ProdID = " + searchItem;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            int qty;

            if (dr.IsDBNull(0))
            {
                qty = 0;
            }
            else
            {
                qty = dr.GetInt32(0);
            }

            conn.Close();

            return qty;
        }
    }
}
