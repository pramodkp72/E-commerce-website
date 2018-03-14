<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NumberOfUsers.aspx.cs" Inherits="NumberOfUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        This is a restricted page which only the staff members have access to.<br />
        <br />
        This page displays the number of customers that have signed up for the website.<br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="The total number of users that have signed up are:"></asp:Label>
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    
        <br />
        <br />
        To go to the staff 2 pages i.e. Customer Data click the button below.<br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Staff 2 Page" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Sign Out" OnClick="Button2_Click" style="height: 26px" />
    
    </div>
    </form>
</body>
</html>
