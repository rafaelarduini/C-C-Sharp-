﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Login : System.Web.UI.UserControl
    {
        public string Mensagem;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensagem.Text = Mensagem;
        }

        [Obsolete]
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "Rafael" && txtSenha.Text == "123456")
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alerta", "<script>alert('" + txtLogin.Text + ", entrou com sucesso');</script>");
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "alerta", "<script>alert('" + txtLogin.Text + ", não existre na base de dados');</script>");
            }
        }
    }
}