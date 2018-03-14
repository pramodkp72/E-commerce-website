<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
      Sign Up Page<br />
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Enter Username"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Enter Password"></asp:Label>
        &nbsp; ( Suggested password =&nbsp;
        <asp:Label ID="Label7" runat="server"></asp:Label>
        &nbsp;)<br />
        <br />
        <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox2_TextChanged" Width="721px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Enter Address"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Enter String Length"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox1_TextChanged" style="height: 22px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button4" runat="server" Text="Generate Image" style="margin-bottom: 0px" OnClick="Button4_Click" />
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="50px" Width="153px" />
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Enter the string"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox1_TextChanged" style="height: 22px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Up" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Go Back To Home" OnClick="Button2_Click" />
        &nbsp;
        <br />
        <br />
        <asp:Label ID="Label3" runat="server"></asp:Label>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
