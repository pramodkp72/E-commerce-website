<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IndexPage.aspx.cs" Inherits="IndexPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .newStyle1 {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        Online E-Commerce System.<br />
        <br />
        This application allows users to create an account and buy the products which are available in the in the application.<br />
        <br />
        1.The users can select the products they want from the catalog.<br />
        2.They can add to the cart and verify their passwords.<br />
        3.If the card is verified then they will get a confirmation message.<br />
        <br />
        This page(IndexPage.aspx) is the public page which is accessible to all the users.<br />
        <br />
        This also consists of some restricted pages which only the admin&#39;s can access.<br />
        They are:<br />
        1.CustomerData.aspx<br />
        2.NumberOfUsers.aspx<br />
        <br />
        NumberOfUsers.aspx can only be accessed by staff1 members.<br />
        CustomerData.aspx can only be accessed by staff2 members.<br />
        <br />
        The login details of some general users are:<br />
        1.User Name: Pramod<br />
&nbsp;&nbsp; Password: Kalidindi<br />
        <br />
        2.User Name: pkalidi1<br />
&nbsp;&nbsp; Password: tendulkar99<br />
        <br />
        3.User Name: vibhuti123<br />
&nbsp;&nbsp; Password: vibhuti123<br />
        <br />
        The Login details for NumberOfUsers.aspx is that is the restricted staff1 members are:<br />
        1.User Name: Rahul<br />
&nbsp;&nbsp; Password: Dravid<br />
        <br />
        2.User Name: Ricky<br />
&nbsp;&nbsp; Password: Ponting<br />
        <br />
        The Login details for CustomerData.aspx is that is the restricted staff1 members are:<br />
        1.User Name: Anil<br />
&nbsp;&nbsp; Password: Kumble<br />
        <br />
        2.User Name: VVS<br />
&nbsp;&nbsp; Password: Laxman<br />
        <br />
        The State Management Techniques I have used is :<br />
        1. Cookies
        <br />
        2. XML files<br />

        <html>
<head>
<title>HTML Table Header</title>
</head>
<body>
<table border="1">
<tr><th bgcolor = "#33FFCE" colspan = "5">This is deployed at:<a href="http://webstrar35.fulton.asu.edu/Page5/IndexPage.aspx">http://webstrar35.fulton.asu.edu/Page5/IndexPage.aspx</a>  </th></tr>
<tr><th bgcolor = "#33FFCE" colspan = "5">This project is developed by: Pramod Kalidindi</th></tr>

<tr>
<th>Provider name</th>
<th>Service name with input and output types</th>
<th>TryIt link</th>
<th>Service description</th>
<th>Actual resources used to implement the service
</th>
</tr>

<tr>
<td>Pramod Kalidindi</td>
<td>Login Input:Two strings Output:string</td>
<td><a href="http://webstrar35.fulton.asu.edu/Page5/Login.aspx">TryIt</a></td>
<td>Stores the username and password in XMl file</td>
<td>Implemented from scratch</td>
</tr>

<tr>
<td>Pramod Kalidindi</td>
<td>Order Processing input:int Output:double</td>
<td><a href="http://webstrar35.fulton.asu.edu/Page5/Login.aspx?ReturnUrl=%2fPage5%2fusers%2fOrderProcessing.aspx">TryIt</a></td>
<td>Takes the final amount from cart and adds the appropriate taxes and shipping charges</td>
<td>Implemented from scratch</td>
</tr>

<tr>
<td>Pramod Kalidindi</td>
<td>Add to cart input:int Output:int</td>
<td><a href="http://webstrar35.fulton.asu.edu/Page5/users/AddToCart_Final.aspx">TryIt</a></td>
<td>Adds the price of the item selected to the cart</td>
<td>Implemented from scratch</td>
</tr>

<tr>
<td>Pramod Kalidindi</td>
<td>Credit card Validation(Luhn's algorithm) input:String Output:string</td>
<td><a href="http://webstrar35.fulton.asu.edu/Page5/Login.aspx?ReturnUrl=%2fPage5%2fusers%2fOrderProcessing.aspx">TryIt</a></td>
<td>Verifies the credit card number</td>
<td>Implemented from scratch</td>
</tr>

<tr>
<td>Pramod Kalidindi</td>
<td>Random String Generator input:No Input Output:string</td>
<td><a href="http://webstrar35.fulton.asu.edu/Page5/SignUp.aspx">TryIt</a></td>
<td>This Generates a random string of length 8</td>
<td>ASU Public Repository: <span style="color: rgb(0, 0, 0); font-family: 'Times New Roman'; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none">&nbsp;</span><a href="http://neptune.fulton.ad.asu.edu/WSRepository/Services/RandomString/Service.svc/GetRandomString/8" style="font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px;">http://neptune.fulton.ad.asu.edu/WSRepository/Services/RandomString/Service.svc/GetRandomString/</a></td>
</tr>

<tr>
<td>Pramod Kalidindi</td>
<td>Image Verifier</td>
<td><a href="http://webstrar35.fulton.asu.edu/Page5/SignUp.aspx">TryIt</a></td>
<td>Implements a captcha.</td>
<td>ASU Public Repository:<br />
    http://neptune.fulton.ad.asu.edu/WSRepository/Services/ImageVerifier/Service.svc/GetImage/<br />
    </td>
</tr>


</table>
</body>
</html>
        <span style="color: rgb(34, 34, 34); font-family: arial, sans-serif; font-size: 12.8px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">&nbsp; &nbsp; </span><br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Users" Height="60px" Width="104px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Staff" Height="59px" Width="104px" />
    
    </div>
    </form>
</body>
</html>
