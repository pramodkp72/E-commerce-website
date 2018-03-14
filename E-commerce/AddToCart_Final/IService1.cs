using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AddToCart_Final
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int addCart(int item);

        [OperationContract]
        int getProductId(string product);

        [OperationContract]
        int removeFromCart(int item);

        [OperationContract]
        int getQuantity(int quantity);
        
    }

}
