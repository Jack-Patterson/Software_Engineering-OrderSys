using System;
using System.Collections.Generic;
using System.Text;
using OrderSys.frmOrders;
using OrderSys.frmProducts;

namespace OrderSys.frmOrders
{
    class ValidateOrder
    {

        public static bool validQuantity(String ordQty, String prodQty, String prodID)
        {
            int orderQuantity;
            int productQuantity;

            if (!int.TryParse(ordQty, out orderQuantity))
            {
                return false;
            }
            if (!int.TryParse(prodQty, out productQuantity))
            {
                return false;
            }
            if (orderQuantity <= 0)
            {
                return false;
            }
            if (orderQuantity > productQuantity)
            {
                return false;
            }
            return true;
        }
    }
}
