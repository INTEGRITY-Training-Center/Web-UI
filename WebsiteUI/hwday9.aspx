<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hwday9.aspx.cs" Inherits="WebsiteUI.hwday9" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input type="text" id="txtfirstnum" value=" " />
        <input type="text" id="txtsecondnum" value=" " />
        <asp:Button ID="btnadd" runat="server" Text="ADD" onclick="btnadd_Click"/>
        <asp:Button ID="btnsubtract" runat="server" Text="SUBTRACT" onclick="btnsubtract_Click"/>
        <asp:Button ID="btnmultiply" runat="server" Text="MULTIPLY" onclick="btnmultiply_Click"/>
        <asp:Button ID="btndivide" runat="server" Text="DIVIDED" onclick="btndivide_Click"/>
    </div>
    </form>
</body>
</html>
