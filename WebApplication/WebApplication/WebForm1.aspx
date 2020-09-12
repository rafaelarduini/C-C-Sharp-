<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtMensagem" runat="server"></asp:TextBox>
        <input type="text" name="telefone" id="telefone" runat="server" />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Mostrar mensagem" />
    </form>
</body>
</html>
