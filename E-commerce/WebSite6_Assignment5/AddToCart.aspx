<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddToCart.aspx.cs" Inherits="AddToCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     Try It Page for Order Processing service<br />
        <br />
        <br />
        </div>
        <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="T Shirts   $20"></asp:Label>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add to Cart" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Shirt   $30"></asp:Label>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add to Cart" />
        <p>
            <asp:Label ID="Label3" runat="server" Text="Trouser   $40"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Add to Cart" />
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Jeans  $35"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Add to Cart" />
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Shorts  $25"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Add to Cart" />
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Socks  $10"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Add to Cart" />
        </p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="Tie   $15"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" style="height: 26px" Text="Add to Cart" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="The total amount without tax is"></asp:Label>
        </p>
        <p>
            &nbsp;<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Confirm Order" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Clear Cart" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label10" runat="server" Text="If the total price is more than $50 dollars then shipping is free!!"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="Label9" runat="server" Text="The total amount with tax and shipping charges are"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
   
    </form>
</body>
</html>
