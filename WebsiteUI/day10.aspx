<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="day10.aspx.cs" Inherits="WebsiteUI.day10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtnum1" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtnum2" runat="server"></asp:TextBox><br /><br />
        
        <asp:Button ID="btnadd" runat="server" Text="+" OnClick="btnadd_Click" />
        <asp:Button ID="btnsubtract" runat="server" Text="-" OnClick="btnsubtract_Click" />
        <asp:Button ID="btnmultiply" runat="server" Text="*" OnClick="btnmultiply_Click" />
        <asp:Button ID="btndivide" runat="server" Text="/" OnClick="btndivide_Click" /><br /><br />

        <asp:Label ID="lblresult" runat="server" Text="RESULT"></asp:Label>

    </div>
    </form>
</body>
</html>
