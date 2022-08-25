using System;
using System.Collections.Generic;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Windows.Forms;

namespace OrderSys.frmSuppliers
{
    class Supplier
    {
        int suppID;
        String name;
        String eirCode;
        String street;
        String town;
        String county;
        String email;
        String phoneNo;
        String contact;

        public Supplier(int suppID, String name, String eirCode, String street, String town, String county, String email, String phoneNo, String contact)
        {
            setSuppID(suppID);
            setName(name);
            setEirCode(eirCode);
            setStreet(street);
            setTown(town);
            setCounty(county);
            setEmail(email);
            setPhoneNo(phoneNo);
            setContact(contact);

        }

        public int getSuppID()
        {
            return suppID;
        }

        public void setSuppID(int suppID)
        {
            this.suppID = suppID;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getEirCode()
        {
            return eirCode;
        }

        public void setEirCode(String eirCode)
        {
            this.eirCode = eirCode;
        }

        public String getStreet()
        {
            return street;
        }

        public void setStreet(String street)
        {
            this.street = street;
        }

        public String getTown()
        {
            return town;
        }

        public void setTown(String town)
        {
            this.town = town;
        }

        public String getCounty()
        {
            return county;
        }

        public void setCounty(String county)
        {
            this.county = county;
        }

        public String getEmail()
        {
            return email;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public String getPhoneNo()
        {
            return phoneNo;
        }

        public void setPhoneNo(String phoneNo)
        {
            this.phoneNo = phoneNo;
        }

        public String getContact()
        {
            return contact;
        }

        public void setContact(String contact)
        {
            this.contact = contact;
        }

        public void registerSupplier()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "INSERT INTO Suppliers VALUES (" +
            getSuppID() + ",'" +
            getName() + "','" +
            getStreet() + "','" +
            getTown() + "','" +
            getCounty() + "','" +
            getEirCode() + "','" +
            getEmail() + "','" +
            getPhoneNo() + "','" +
            getContact() + "')";

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public static int getNextSuppID()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT MAX(SuppID) FROM Suppliers";

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

        public static DataSet searchSuppName(String searchItem)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT SuppID,Name FROM Suppliers WHERE Name LIKE '" + searchItem + "%' ORDER BY Name";

            DataSet ds = new DataSet();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds,"SUPP");
            conn.Close();

            return ds;
        }

        public static DataSet searchAllSuppName()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT SuppID,Name FROM Suppliers ORDER BY Name";

            DataSet ds = new DataSet();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "SUPP");
            conn.Close();

            return ds;
        }

        public static DataSet searchAllSuppInfo(String searchItem)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "SELECT * FROM Suppliers WHERE Name LIKE '" + searchItem + "'";

            DataSet ds = new DataSet();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);

            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "SUPP");
            conn.Close();

            return ds;
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

        public void UpdateSupplier()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            String sqlQuery = "UPDATE Suppliers SET " +
            "Name = '" + getName() + "'," +
            "Address_Eir = '" + getEirCode() + "'," +
            "Address_Street = '" + getStreet() + "'," +
            "Address_Town = '" + getTown() + "'," +
            "Address_County = '" + getCounty() + "'," +
            "Email = '" + getEmail() + "'," +
            "PhoneNo = '" + getPhoneNo() + "'," +
            "Contact = '" + getContact() + "'" +
            " WHERE SuppID = " + getSuppID();

            OracleCommand cmd = new OracleCommand(sqlQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
