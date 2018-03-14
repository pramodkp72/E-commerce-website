using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AddToCart_Final
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //Here we are returning the product id when the user selects an item to buy
        public int getProductId(string product)
        {
            int id;
            if (product == "Computer")
            {
                id = 101;
                return id;
            }
            else if (product == "Laptop")
            {
                id = 102;
                return id;
            }
            else if (product == "Keyboard")
            {
                id = 103;
                return id;
            }
            else if (product == "Mouse")
            {
                id = 104;
                return id;
            }
            else if (product == "Usb Cable")
            {
                id = 105;
                return id;
            }
            else if (product == "Bluetooth Speaker")
            {
                id = 106;
                return id;
            }
            else
            {
                return 0;
            }

        }

        //Here we are returning the total price of an item when the user adds an item to the cart
        public int addCart(int item)
        {
            int sum = 0;
            sum += item;
            return sum;
        }

        //The user can also remove items from the cart
        public int removeFromCart(int item)
        {
            return item;
        }

        //The user can select the number of items he wants for a particular item
        public int getQuantity(int quantity)
        {
            return quantity;
        }

    }
}
