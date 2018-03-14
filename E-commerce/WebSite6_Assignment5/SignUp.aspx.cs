using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EncryptAndDecrypt;
using System.Net;
using System.IO;
using System.Runtime.Serialization;


public partial class SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create the base address to the OrderProcessing service
        // Uri baseUri = new Uri("http://localhost:60825/Service1.svc/");
        //We are constructing the base url.
        Uri baseUri = new Uri("http://neptune.fulton.ad.asu.edu/WSRepository/Services/RandomString/Service.svc/GetRandomString/8");

        //Then we are passing the method name and parameter
       // UriTemplate myTemplate = new UriTemplate("OrderProcessing?price1={final_price}");
        //We are binding th uri's
       // Uri completeUri = myTemplate.BindByPosition(baseUri, final_price.ToString());

        WebClient proxy = new WebClient();

        byte[] abc = proxy.DownloadData(baseUri);
        Stream strm = new MemoryStream(abc);
        //We are returning the type as double
        DataContractSerializer obj = new DataContractSerializer(typeof(string));
        string generatedString = obj.ReadObject(strm).ToString();
        Label7.Text = generatedString;
        //  TextBox2.Text = completeUri.ToString();
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         //We take the input from the user and store it in the xml file.
        if (Session["genstr"].ToString() == TextBox4.Text)
        {


            String username = TextBox1.Text;
            String password = TextBox2.Text;
            Class1 obj = new Class1();
            String encrypted = obj.Encrypt(password);
            string address = TextBox3.Text;
            SignUpAndAddressService.Service1Client signup = new SignUpAndAddressService.Service1Client();

            bool verify = signup.Login(username, encrypted);
            if (!verify)
            {
                // LoginAndSignUp.Service1Client login = new LoginAndSignUp.Service1Client();
                signup.SignUp(username, password, address);
                Label3.Text = "You have signed up";
            }
            else
            {
                Label3.Text = "You have already signed up";
            }
        }
        else 
        {
            Label3.Text = "not match";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/IndexPage.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Staff/NumberOfUsers.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

        ImageVerifierService.ServiceClient image = new ImageVerifierService.ServiceClient();
        try
        {
            string genstr = image.GetVerifierString(TextBox5.Text);
            Image1.Visible = true;
            Session["genstr"] = genstr;
            Image1.ImageUrl = "http://neptune.fulton.ad.asu.edu/WSRepository/Services/ImageVerifier/Service.svc/GetImage/" + genstr;
        }
        catch (Exception ex)
        {
            Label3.Text = ex.Message;
        }
    }
}