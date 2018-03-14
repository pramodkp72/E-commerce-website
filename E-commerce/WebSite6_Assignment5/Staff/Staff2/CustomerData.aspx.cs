using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerData : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SignUpAndAddressService.Service1Client customer = new SignUpAndAddressService.Service1Client();
        //LoginServiceReference.Service1Client cl = new LoginServiceReference.Service1Client();
        string datalist = customer.CustomerData();
        string[] fdata = datalist.Split(';');
        // DataLabel.Text = fdata;
        GridView1.DataSource = fdata;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        FormsAuthentication.SignOut();
        Response.Redirect("~/IndexPage.aspx");
    }
}