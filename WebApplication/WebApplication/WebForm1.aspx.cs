using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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