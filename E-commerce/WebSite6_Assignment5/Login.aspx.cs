using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.Security;
using EncryptAndDecrypt;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("SignUp.aspx");

        /*
        //We take the input from the user and store it in the xml file.
        String username = TextBox1.Text;
        String password = TextBox2.Text;
        LoginAndSignUp.Service1Client login = new LoginAndSignUp.Service1Client();
        login.SignUp(username, password);
         */
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        String username = TextBox1.Text;
        String password = TextBox2.Text;

        Class1 obj = new Class1();
        String encrypted = obj.Encrypt(password);
      //  LoginAndSignUp.Service1Client login = new LoginAndSignUp.Service1Client();
       // Login.Service1Client login = new Login.Service1Client();
        SignUpAndAddressService.Service1Client login = new SignUpAndAddressService.Service1Client();
        bool result = login.Login(username, encrypted);
       // bool result = login.Login(username, password);

        HttpCookie myCookies = new HttpCookie("myCookieId");
        myCookies["UserName"] = TextBox1.Text;
        myCookies.Expires = DateTime.Now.AddDays(20);
        Response.Cookies.Add(myCookies);
       
        if(result)
        {
           // Response.Redirect("AddToCart_Final.aspx");
            FormsAuthentication.RedirectFromLoginPage(TextBox1.Text, false);
        }
        else
        {
            Label3.Text = "Please Check The credentials ";
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("IndexPage.aspx");
    }
}