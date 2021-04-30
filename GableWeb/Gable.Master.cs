using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GableWeb
{
    public partial class Gable : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCesta_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cesta.aspx");
        }

        /*  protected void ShowMenu(object sender, EventArgs e)
          {
              lista.display = inline;
          }*/
    }
}