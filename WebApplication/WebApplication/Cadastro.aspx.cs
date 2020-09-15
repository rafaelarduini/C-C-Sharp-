using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication.App_Code;

namespace WebApplication
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarLista();
        }

        private void mostrarLista()
        {
            pnlCamposCadastro.Visible = false;
            pnlResultado.Visible = true;

            gridResultado.DataSource = Usuario.Lista;
            gridResultado.DataBind();
        }

        private void mostrarCadastro()
        {
            pnlCamposCadastro.Visible = true;
            pnlResultado.Visible = false;
        }

        protected void btbSalvar_Click(object sender, EventArgs e)
        {
            string caminhoArquivo = AppDomain.CurrentDomain.BaseDirectory + System.Configuration.ConfigurationManager.AppSettings["caminhoArquivo"] + @"\" + fileFoto.FileName;
            fileFoto.SaveAs(caminhoArquivo);

            var usuario = new Usuario();
            usuario.Nome = txtNome.Text;
            usuario.Telefone = txtTelefone.Text;
            usuario.Foto = System.Configuration.ConfigurationManager.AppSettings["caminhoArquivo"].Replace(@"\","/") + "/" + fileFoto.FileName;
            usuario.Salvar();

            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;

            mostrarLista();
        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            mostrarCadastro();
        }
    }
}