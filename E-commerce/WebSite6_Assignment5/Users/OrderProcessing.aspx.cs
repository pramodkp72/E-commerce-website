using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;

public partial class OrderProcessing : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myCookies1 = Request.Cookies["myCookieCart"];
     
            TextBox1.Text = myCookies1["FinalPrice"];

            
            OrderProcessingService.Service1Client order = new OrderProcessingService.Service1Client();
            double price = order.OrderProcessing(TextBox1.Text);
            TextBox3.Text = Convert.ToString(price);
       
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        HttpCookie myCookies = Request.Cookies["myCookieId"];
        SignUpAndAddressService.Service1Client address = new SignUpAndAddressService.Service1Client();
        string username = myCookies["UserName"];
        string address1 = address.getAddress(username);

        string credit_card = TextBox2.Text;
        CreditCardService.Service1Client card = new CreditCardService.Service1Client();
        bool confirmation = card.creditCardVerification(credit_card);
        if(confirmation)
        {
            Label3.Text = "The card is verified and the product will be shipped shortly to" + address1;
        }
        else
        {
            Label3.Text = "Please check the card you have entered";
        }
    }
}