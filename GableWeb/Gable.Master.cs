using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace GableWeb
{
    public partial class Gable : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if (Session["dni"] != null)
                {
                    ENUsuario usu = new ENUsuario();
                    usu.dni = Session["dni"].ToString();
                    usu.readUsuario();
                    init_sesion.Text = "Area Personal de " + usu.nombre;
                }
        }

        protected void btnCesta_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cesta.aspx");
        }

        protected void btnGableLogo_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if(Session["dni"] == null) { 
                Response.Redirect("Login.aspx");
            } else
            {
                Response.Redirect("AreaPersonal_ped.aspx");
            }

        }

        protected void lupita(object sender, EventArgs e)
        {
            Response.Redirect("Resultado_busqueda.aspx?cat_prod="+ searcher.Text);
        }
        
    }
}