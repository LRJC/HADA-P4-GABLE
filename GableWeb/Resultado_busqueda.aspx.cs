using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GableWeb
{
    public partial class Resultado_busqueda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void clickado(object sender, CommandEventArgs e)
        {
            Response.Redirect("Productos.aspx?id_prod=" + e.CommandArgument);
        }
    }
}