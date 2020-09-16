<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="WebApplication.Login" %>
<div class="login">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Login: "></asp:Label>
        <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Senha: "></asp:Label>
        <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    </div>
</div>
<p>
    &nbsp;</p>
<asp:Label ID="lblMensagem" runat="server" Text="[Mensagem]"></asp:Label>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
