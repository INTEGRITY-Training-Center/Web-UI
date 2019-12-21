<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="day9.aspx.cs" Inherits="WebsiteUI.day9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--<label id="lblwc" runat="server"></label>--%>
        <label id="lblname" runat="server"></label>
        <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
        <asp:Button ID="btnsave" runat="server" Text="SAVE" OnClick="btnsave_Click" />
    </div>
    </form>
</body>
</html>
