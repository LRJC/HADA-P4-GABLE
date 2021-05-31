using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace GableWeb
{
    public partial class AreaPersonal_modData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["dni"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                setClientArea(Session["dni"].ToString());
            }
        }

        protected void setClientArea(string dni)
        {
            ENUsuario usu = new ENUsuario();
            usu.nif = dni;
            if (!usu.readUsuario())//no existe el usuario de la sesión actual
            {
                Session.RemoveAll();
                Session.Abandon();
                Response.Redirect("Login.aspx");
            }
            else
            {
                lab_NombreApellidos_AreaPersonal_mod.Text = usu.nombre.ToString() + " " + usu.apellidos.ToString();
                lab_Dni_AreaPersonal_mod.Text = usu.nif.ToString();
                lab_Correo_AreaPersonal_mod.Text = usu.email.ToString();
            }
        }

        protected void ButtonCambiarContra_Click(object sender, EventArgs e)
        {
            //actualizar la contraseña en la bbdd
        }

        protected void ButtonCambiarDatosPersonales_Click(object sender, EventArgs e)
        {
            //actualizar los datos personales en la bbdd
        }

        protected void ButtonCambiarInfoPagos_Click(object sender, EventArgs e)
        {
            //actualizar la informacion de pago en la bbdd
        }
    }
}