<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerData.aspx.cs" Inherits="CustomerData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        These are the details of the customers who have registered which contains the username and their corresponding address&#39;.<br />
        <br />
    
    </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sign Out" />
    </form>
</body>
</html>
