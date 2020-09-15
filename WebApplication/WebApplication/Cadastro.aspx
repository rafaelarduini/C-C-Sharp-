﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="WebApplication.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        img{
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="pnlCamposCadastro" runat="server">
            <asp:Label ID="Label1" runat="server" Text="Nome"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Telefone"></asp:Label>
            <asp:TextBox ID="txtTelefone" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Foto"></asp:Label>
            <asp:FileUpload ID="fileFoto" runat="server" />
            <br />
            <asp:Button ID="btbSalvar" runat="server" Text="Salvar" OnClick="btbSalvar_Click" />
        </asp:Panel>
        <asp:Panel ID="pnlResultado" runat="server">
            <asp:Button ID="btnCadastro" runat="server" Text="Novo Cadastro" OnClick="btnCadastro_Click" />
            <hr />
            <asp:GridView ID="gridResultado" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                    <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                    <asp:ImageField DataImageUrlField="Foto" HeaderText="Foto">
                    </asp:ImageField>
                </Columns>
            </asp:GridView>
        </asp:Panel>
    </form>
</body>
</html>
