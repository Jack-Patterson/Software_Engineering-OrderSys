using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSys.frmProducts
{
    class ValidateProduct
    {
        // Used to validate name.
        public static bool validName(String name)
        {
            int numeric;
            if (name.Length > 0 && name.Length < 30)
            {
                if (!int.TryParse(name, out numeric))
                {
                    return true;
                }
            }
            return false;
            
        }

        // Used to validate price
        public static bool validNumber(string number)
        {
            float no;
            bool noParse = float.TryParse(number, out no);
            if (number.Equals(""))
            {
                return false;
            }
            
            if (no >= 0)
            {
                return true;
            }
            if (noParse)
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
