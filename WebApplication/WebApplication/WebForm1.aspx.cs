using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication;

namespace WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Contato> contatos = new List<Contato>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrLogin.Mensagem = "default pagina";

            contatos.Add(new Contato() { Nome = "Rafael", Id = 1 });
            contatos.Add(new Contato() { Nome = "Aline", Id = 2 });
            contatos.Add(new Contato() { Nome = "Marie", Id = 3 });
            contatos.Add(new Contato() { Nome = "Nina", Id = 4 });

            ddlContatos.DataSource = contatos;
            ddlContatos.DataValueField = "Id";
            ddlContatos.DataTextField = "Nome";
            ddlContatos.DataBind();

            selectManualRunatServer.InnerHtml = "<select>";

            foreach (var contato in contatos)
            {
                selectManualRunatServer.InnerHtml += "<option value ='" + contato.Id + "' >" + contato.Nome + "</ option >";
            }
            selectManualRunatServer.InnerHtml += "</select>";
            
            GridView1.DataSource = contatos;
            GridView1.DataBind();
        }

        protected void btnOk_Click(object sender, EventArgs e)
        {
            Response.Write("Olá " + txtMensagem.Text + "<br>");
            Response.Write("Olá " + Request["txtMensagem"]);
            Response.Write("Telefone" + Request["telefone"] + telefone.Value);

            //Response.Write("<script>alert('Olá " + txtMensagem.Text +"')</script>");
        }
    }
}
