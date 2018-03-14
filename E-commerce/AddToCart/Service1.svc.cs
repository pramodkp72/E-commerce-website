using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AddToCart
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //This is the service which I converted into a restful service.

        //This is a service where the user adds everything to the cart and we process the final order.
        public double OrderProcessing(string price1)
        {
            //We take the input as a string and convert it into int.
            int price = Convert.ToInt32(price1);
            //The tax per each item is 0.15 dollars
            double tax = 0.15;
            // The shipping charges is $50 dollars
            int shipping_charges = 50;
            double total_tax = (price * tax);
            double total_price = price + total_tax;
            //If the total price is below $50 dollars we add shipping charges or else we do not
            if (total_price < 50)
            {
                double complete_price = total_price + shipping_charges;
                return complete_price;
            }
            else
            {
                return total_price;
            }
        }
    }
}
