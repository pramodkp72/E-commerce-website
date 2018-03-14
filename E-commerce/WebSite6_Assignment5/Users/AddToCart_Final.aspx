<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddToCart_Final.aspx.cs" Inherits="AddToCart_Final" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>

        <asp:Label ID="Label9" runat="server"></asp:Label>

        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Computer"></asp:Label>
&nbsp;
        <asp:Label ID="Label2" runat="server" Text="$ 700"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label7" runat="server" Text="Enter the quantity"></asp:Label>
&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add To Cart" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Remove From Cart" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Laptop"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="$ 900"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text="Enter the quantity"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add To cart" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Remove From Cart" />
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Keyboard"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label11" runat="server" Text="$ 100"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label12" runat="server" Text="Enter the quantity"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button7" runat="server" Text="Add To cart" OnClick="Button7_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button8" runat="server" Text="Remove From Cart" OnClick="Button8_Click" />
        <br />
        <br />
        <asp:Label ID="Label13" runat="server" Text="Mouse"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label14" runat="server" Text="$ 30"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label15" runat="server" Text="Enter the quantity"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button9" runat="server" Text="Add To cart" OnClick="Button9_Click" style="height: 26px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button10" runat="server" Text="Remove From Cart" OnClick="Button10_Click" />
        <br />
        <br />
        <asp:Label ID="Label16" runat="server" Text="Usb Cable"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label17" runat="server" Text="$ 15"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label18" runat="server" Text="Enter the quantity"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button11" runat="server" Text="Add To cart" OnClick="Button11_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button12" runat="server" Text="Remove From Cart" OnClick="Button12_Click" />
        <br />
        <br />
        <asp:Label ID="Label19" runat="server" Text="Bluetooth Speaker"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label20" runat="server" Text="$ 200"></asp:Label>
&nbsp;&nbsp; <asp:Label ID="Label21" runat="server" Text="Enter the quantity"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button13" runat="server" Text="Add To cart" OnClick="Button13_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button14" runat="server" Text="Remove From Cart" OnClick="Button14_Click" />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp; 
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Label5" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="The total amount is:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        &nbsp;
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Proceed To Checkout" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button6" runat="server" Text="Sign Out" OnClick="Button6_Click" />
    </form>
</body>
</html>
