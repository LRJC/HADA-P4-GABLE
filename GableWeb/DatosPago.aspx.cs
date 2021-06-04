using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace GableWeb
{
    public partial class DatosPago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            ENUsuario user = new ENUsuario();
            user.dni = Session["dni"].ToString();
            if(user.readUsuario())
            {
                user.cvv = Convert.ToInt32(cvv.Text);
                user.numTarjeta = Convert.ToInt32(numTarjeta.Text);
                user.expTarjeta = fechaExp.Text;
                user.updateUsuario();
                Response.Redirect("Cesta.aspx");
            }
            else outputMsg.Text = "No ha sido añadir los datos";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}