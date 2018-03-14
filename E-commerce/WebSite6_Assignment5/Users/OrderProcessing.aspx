<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderProcessing.aspx.cs" Inherits="OrderProcessing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Order Processing
        <br />
        <br />
        The total amount in your cart is<br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="The total amount after tax is"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter your credit card number"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Verify" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
