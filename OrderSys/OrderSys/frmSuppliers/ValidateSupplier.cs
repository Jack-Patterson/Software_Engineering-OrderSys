using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace OrderSys.frmSuppliers
{
    class ValidateSupplier
    {
        // Used to validate name.
        public static bool validName(String name)
        {
            if (name.Length > 0 && name.Length < 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Used to validate Eir Code.
        public static bool validEirCode(String eirCode)
        {
            if (eirCode.Length < 7 || eirCode.Length > 7)
            {
                return false;
            }
            else if (!Char.IsLetter(eirCode[0]))
            {
                return false;
            }
            else if (!Char.IsDigit(eirCode[1]) || !Char.IsDigit(eirCode[2]))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        
        // Used to validate both town and street.
        public static bool validAddress(String address)
        {
            if (address.Length > 0 && address.Length < 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Validate County
        public static bool validCounty(String county)
        {
            String[] countiesList = new string[] { "Antrim", "Armagh", "Carlow", "Cavan", "Clare", "Cork", "Derry", "Donegal", "Down", "Dublin", "Fermanagh", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Tyrone", "Waterford", "Westmeath", "Wexford", "Wicklow" };
            county = county.ToUpper();
            
            for (int i = 0; i < countiesList.Length; i++)
            {
                if (county.Equals(countiesList[i].ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool validEmail(String email)
        {
            try
            {
                MailAddress mail = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        public static bool validPhoneNo(string phoneNo)
        {
            if (phoneNo.Length < 10 || phoneNo.Length > 10)
            {
                return false;
            }
            else if (!phoneNo.StartsWith("08"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool validContact(string contact)
        {
            if (contact.Length > 0 && contact.Length < 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
