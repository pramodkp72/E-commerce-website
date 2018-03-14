using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NumberOfUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SignUpAndAddressService.Service1Client number = new SignUpAndAddressService.Service1Client();
        int users = number.getNumberOfUsers();
        TextBox1.Text = Convert.ToString(users);
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Staff2/CustomerData.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
	    Response.Redirect("~/IndexPage.aspx");

    }
} 