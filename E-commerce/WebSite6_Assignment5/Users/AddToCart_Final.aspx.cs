using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.Security;

public partial class AddToCart_Final : System.Web.UI.Page
{


    static int final_sum = 0;
    static int count_computer = 0;
    static int count_laptop = 0;

    static int keyboard = 0;
    static int mouse = 0;
    static int usb = 0;
    static int speaker = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myCookies = Request.Cookies["myCookieId"];
        if ((myCookies == null) || (myCookies["UserName"] == ""))
        {
            Label9.Text = "Welcome new user!";

        }
        else
        {
            Label9.Text = "Welcome" + " " + myCookies["UserName"];
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            //This is the button where we add a computer to our cart
           // AddToCart.Service1Client add = new AddToCart.Service1Client();
            AddToCartService.Service1Client add = new AddToCartService.Service1Client();
            int sum = add.addCart(700);
            int quantity = add.getQuantity(Convert.ToInt32(TextBox2.Text));
            count_computer = quantity;
            final_sum = final_sum + (sum * quantity);
            // final_sum += add.addCart(700);
            int product_id = add.getProductId(Label1.Text);
            string confirmation = "The item has been successfully added into the cart and the product id is " + product_id;
            // string confirmation = "The item has been successfully added into the cart";
            Label5.Text = confirmation;
            TextBox1.Text = Convert.ToString(final_sum);

           



            /*
            myCookies["FinalPrice"] = TextBox1.Text;
             myCookies.Expires = DateTime.Now.AddDays(20);
             Response.Cookies.Add(myCookies);
             */

        }
        catch (Exception ex)
        {
            Label5.Text = ex.Message;
        }


    }
    protected void Button3_Click(object sender, EventArgs e)
    {
       // AddToCart.Service1Client add = new AddToCart.Service1Client();
        AddToCartService.Service1Client add = new AddToCartService.Service1Client();
        int remove = add.removeFromCart(700);
        count_computer--;
        if (count_computer >= 0)
        {
            final_sum = final_sum - remove;
            TextBox1.Text = Convert.ToString(final_sum);
            string confirmation = "The item has been successfully removed from the cart";
            Label5.Text = confirmation;
        }
        else
        {
            string confirmation = "The item has already been removed";
            Label5.Text = confirmation;
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            //This is the button where we add a laptop to our cart
           // AddToCart.Service1Client add = new AddToCart.Service1Client();
            AddToCartService.Service1Client add = new AddToCartService.Service1Client();
            int sum = add.addCart(900);
            int quantity = add.getQuantity(Convert.ToInt32(TextBox3.Text));
            count_laptop = quantity;
            final_sum = final_sum + (sum * quantity);
            // final_sum += add.addCart(900);
            int product_id = add.getProductId(Label3.Text);
            string confirmation = "The item has been successfully added into the cart and the product id is " + product_id;
            Label5.Text = confirmation;
            TextBox1.Text = Convert.ToString(final_sum);


            /*
            myCookies["FinalPrice"] = TextBox1.Text;
             myCookies.Expires = DateTime.Now.AddDays(20);
             Response.Cookies.Add(myCookies);
             */

        }
        catch (Exception ex)
        {
            Label5.Text = ex.Message;
        }

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
       // AddToCart.Service1Client add = new AddToCart.Service1Client();
        AddToCartService.Service1Client add = new AddToCartService.Service1Client();
        int remove = add.removeFromCart(900);
        count_laptop--;
        if (count_laptop >= 0)
        {
            final_sum = final_sum - remove;
            TextBox1.Text = Convert.ToString(final_sum);
            string confirmation = "The item has been successfully removed from the cart";
            Label5.Text = confirmation;
        }
        else
        {
            string confirmation = "The item has already been removed";
            Label5.Text = confirmation;
        }

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button5_Click(object sender, EventArgs e)
    {

        HttpCookie myCookies1 = new HttpCookie("myCookieCart");
        myCookies1["FinalPrice"] = Convert.ToString(final_sum); ;
       // myCookies1["FinalPrice"] = TextBox1.Text;
        myCookies1.Expires = DateTime.Now.AddDays(20);
        Response.Cookies.Add(myCookies1);
        Response.Redirect("OrderProcessing.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("~/IndexPage.aspx");
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        try
        {
            //This is the button where we add a computer to our cart
            // AddToCart.Service1Client add = new AddToCart.Service1Client();
            AddToCartService.Service1Client add = new AddToCartService.Service1Client();
            int sum = add.addCart(100);
            int quantity = add.getQuantity(Convert.ToInt32(TextBox4.Text));
            keyboard = quantity;
            final_sum = final_sum + (sum * quantity);
            // final_sum += add.addCart(700);
            int product_id = add.getProductId(Label10.Text);
            string confirmation = "The item has been successfully added into the cart and the product id is " + product_id;
            // string confirmation = "The item has been successfully added into the cart";
            Label5.Text = confirmation;
            TextBox1.Text = Convert.ToString(final_sum);


        }
        catch (Exception ex)
        {
            Label5.Text = ex.Message;
        }
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        AddToCartService.Service1Client add = new AddToCartService.Service1Client();
        int remove = add.removeFromCart(100);
        keyboard--;
        if (keyboard >= 0)
        {
            final_sum = final_sum - remove;
            TextBox1.Text = Convert.ToString(final_sum);
            string confirmation = "The item has been successfully removed from the cart";
            Label5.Text = confirmation;
        }
        else
        {
            string confirmation = "The item has already been removed";
            Label5.Text = confirmation;
        }

    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        //This is the button where we add a computer to our cart
            // AddToCart.Service1Client add = new AddToCart.Service1Client();
        try{
            AddToCartService.Service1Client add = new AddToCartService.Service1Client();
            int sum = add.addCart(30);
            int quantity = add.getQuantity(Convert.ToInt32(TextBox5.Text));
            mouse = quantity;
            final_sum = final_sum + (sum * quantity);
            // final_sum += add.addCart(700);
            int product_id = add.getProductId(Label13.Text);
            string confirmation = "The item has been successfully added into the cart and the product id is " + product_id;
            // string confirmation = "The item has been successfully added into the cart";
            Label5.Text = confirmation;
            TextBox1.Text = Convert.ToString(final_sum);
        }

        catch (Exception ex)
        {
            Label5.Text = ex.Message;
        }
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        AddToCartService.Service1Client add = new AddToCartService.Service1Client();
        int remove = add.removeFromCart(30);
        mouse--;
        if (mouse >= 0)
        {
            final_sum = final_sum - remove;
            TextBox1.Text = Convert.ToString(final_sum);
            string confirmation = "The item has been successfully removed from the cart";
            Label5.Text = confirmation;
        }
        else
        {
            string confirmation = "The item has already been removed";
            Label5.Text = confirmation;
        }

    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        //This is the button where we add a computer to our cart
        // AddToCart.Service1Client add = new AddToCart.Service1Client();
        try
        {
            AddToCartService.Service1Client add = new AddToCartService.Service1Client();
            int sum = add.addCart(15);
            int quantity = add.getQuantity(Convert.ToInt32(TextBox6.Text));
            usb = quantity;
            final_sum = final_sum + (sum * quantity);
            // final_sum += add.addCart(700);
            int product_id = add.getProductId(Label16.Text);
            string confirmation = "The item has been successfully added into the cart and the product id is " + product_id;
            // string confirmation = "The item has been successfully added into the cart";
            Label5.Text = confirmation;
            TextBox1.Text = Convert.ToString(final_sum);
        }

        catch (Exception ex)
        {
            Label5.Text = ex.Message;
        }
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        AddToCartService.Service1Client add = new AddToCartService.Service1Client();
        int remove = add.removeFromCart(15);
        usb--;
        if (usb >= 0)
        {
            final_sum = final_sum - remove;
            TextBox1.Text = Convert.ToString(final_sum);
            string confirmation = "The item has been successfully removed from the cart";
            Label5.Text = confirmation;
        }
        else
        {
            string confirmation = "The item has already been removed";
            Label5.Text = confirmation;
        }

    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        //This is the button where we add a computer to our cart
        // AddToCart.Service1Client add = new AddToCart.Service1Client();
        try
        {
            AddToCartService.Service1Client add = new AddToCartService.Service1Client();
            int sum = add.addCart(200);
            int quantity = add.getQuantity(Convert.ToInt32(TextBox7.Text));
            speaker = quantity;
            final_sum = final_sum + (sum * quantity);
            // final_sum += add.addCart(700);
            int product_id = add.getProductId(Label19.Text);
            string confirmation = "The item has been successfully added into the cart and the product id is " + product_id;
            // string confirmation = "The item has been successfully added into the cart";
            Label5.Text = confirmation;
            TextBox1.Text = Convert.ToString(final_sum);
        }

        catch (Exception ex)
        {
            Label5.Text = ex.Message;
        }
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        AddToCartService.Service1Client add = new AddToCartService.Service1Client();
        int remove = add.removeFromCart(200);
        speaker--;
        if (speaker >= 0)
        {
            final_sum = final_sum - remove;
            TextBox1.Text = Convert.ToString(final_sum);
            string confirmation = "The item has been successfully removed from the cart";
            Label5.Text = confirmation;
        }
        else
        {
            string confirmation = "The item has already been removed";
            Label5.Text = confirmation;
        }

    }
}
