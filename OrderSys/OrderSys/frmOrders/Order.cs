using System;
using System.Collections.Generic;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace OrderSys.frmOrders
{
    class Order
    {
        int orderID;
        DateTime date;
        decimal total;
        int suppID;
        char invPaid;

        public Order(int orderID, decimal total, int suppID, char invPaid)
        {
            setOrderID(orderID);
            setTotal(total);
            setSuppID(suppID);
            setInvPaid(invPaid);
        }

        public int getOrderID()
        {
            return orderID;
        }

        public void setOrderID(int orderID)
        {
            this.orderID = orderID;
        }

        public DateTime getDate()
        {
            return date;
        }

        public void setDate(DateTime date)
        {
            this.date = date;
        }

        public decimal getTotal()
        {
            return total;
        }

        public void setTotal(decimal total)
        {
            this.total = total;
        }

        public int getSuppID()
        {
            return suppID;
        }

        public void setSuppID(int suppID)
        {
            this.suppID = suppID;
        }

        public char getInvPaid()
        {
            return invPaid;
        }

        public void setInvPaid(char invPaid)
        {
            this.invPaid = invPaid;
        }

        public static int getNextOrdID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT MAX(OrderID) FROM Orders";

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

        public static void removeQuantity(String prodID, int ordQTy)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Products SET " +
            "Qty = Qty - " + ordQTy +
            " WHERE ProdID = " + prodID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static string getQuantity(String item)
        {
            string quantity = "";

            for (int i = 7; i <= 10; i++)
            {
                quantity += item[i];
            }

            return quantity;
        }

        public static string getPrice(String item)
        {
            string price = "";

            for (int i = 16; i < 21; i++)
            {
                price += item[i];
            }

            return price;
        }

        public void placeOrder()
        {
            String dateString = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();

            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Orders VALUES (" +
            getOrderID() + "," +
            "TO_DATE('" + dateString + "','YYYY-MM-DD')" + "," +
            getTotal() + "," +
            getSuppID() + ",'" +
            getInvPaid() + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet getUnpaidOrder(string suppID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT OrderID, OrderDate, OrderValue FROM Orders WHERE SuppID LIKE " + suppID + " AND PaidInv = 'N' ORDER BY OrderID";

            DataSet ds = new DataSet();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ORD");
            conn.Close();

            return ds;
        }

        public static DataSet getSuppData(string suppID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Suppliers WHERE SuppID LIKE " + suppID + " ORDER BY Name";

            DataSet ds = new DataSet();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "SUPP");
            conn.Close();

            return ds;
        }

        public static DataSet getOrdItemData(string orderID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            int tmp;
            string s = "";
            for (int i = 0; i < orderID.Length; i++)
            {
                if (int.TryParse(orderID[i].ToString(), out tmp)){
                    s += orderID[i];
                }
                else
                {
                    break;
                }
            }

            String sqlQuery = "SELECT * FROM OrderItems WHERE OrderID LIKE " + s;

            DataSet ds = new DataSet();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "ORDIT");
            conn.Close();

            return ds;
        }

        public static string getProdName(string prodID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            int tmp;
            string s = "";
            for (int i = 0; i < prodID.Length; i++)
            {
                if (int.TryParse(prodID[i].ToString(), out tmp))
                {
                    s += prodID[i];

                }
                else
                {
                    break;
                }
            }

            String sqlQuery = "SELECT Name FROM Products WHERE ProdID LIKE " + s;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            string name;

            name = dr.GetString(0);

            conn.Close();

            return name;
        }

        public static decimal getTotal(string orderID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            int tmp;
            string s = "";
            for (int i = 0; i < orderID.Length; i++)
            {
                if (int.TryParse(orderID[i].ToString(), out tmp))
                {
                    s += orderID[i];

                }
                else
                {
                    break;
                }
            }

            String sqlQuery = "SELECT OrderValue FROM Orders WHERE OrderID LIKE " + s;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            decimal value;

            value = dr.GetDecimal(0);

            conn.Close();

            return value;
        }

        public static void payInvoice(string orderID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            int tmp;
            string s = "";
            for (int i = 0; i < orderID.Length; i++)
            {
                if (int.TryParse(orderID[i].ToString(), out tmp))
                {
                    s += orderID[i];

                }
                else
                {
                    break;
                }
            }

            String sqlQuery = "UPDATE Orders SET " +
            "PaidInv = 'Y' " +
            "WHERE OrderID = " + s;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public static string getDate(string orderID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT OrderDate FROM Orders WHERE OrderID LIKE " + orderID;

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            string value;

            value = dr.GetString(0);

            conn.Close();
            
            string tmp = "";
            for (int i = 0; i < 9; i++)
            {
                tmp += value[i];
            }

            return tmp;
        }

        public class OrderItem
        {
            int orderID;
            int prodID;
            int qty;
            decimal salePrice;

            public OrderItem(int orderID, int prodID, int qty, decimal salePrice)
            {
                setOrderID(orderID);
                setProdID(prodID);
                setQty(qty);
                setSalePrice(salePrice);
            }

            public int getOrderID()
            {
                return orderID;
            }

            public void setOrderID(int orderID)
            {
                this.orderID = orderID;
            }

            public int getProdID()
            {
                return prodID;
            }

            public void setProdID(int prodID)
            {
                this.prodID = prodID;
            }

            public int getQty()
            {
                return qty;
            }

            public void setQty(int qty)
            {
                this.qty = qty;
            }

            public decimal getSalePrice()
            {
                return salePrice;
            }

            public void setSalePrice(decimal salePrice)
            {
                this.salePrice = salePrice;
            }

            public void addOrderItem()
            {
                String dateString = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();

                OracleConnection conn = new OracleConnection(DBConnect.oradb);

                String sqlQuery = "INSERT INTO OrderItems VALUES (" +
                getOrderID() + "," +
                getProdID() + "," +
                getQty() + "," +
                getSalePrice() + ")";

                OracleCommand cmd = new OracleCommand(sqlQuery, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}
