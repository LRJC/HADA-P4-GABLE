using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace GableWeb
{
    public partial class AreaPersonal : System.Web.UI.Page
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
            usu.dni = dni;
            if (!usu.readUsuario())//no existe el usuario de la sesión actual
            {
                Session.RemoveAll();
                Session.Abandon();
                Response.Redirect("Login.aspx");
            }
            else
            {
                lab_NombreApellidos_AreaPersonal.Text = usu.nombre.ToString() + " " + usu.apellidos.ToString();
                lab_Dni_AreaPersonal.Text = usu.dni.ToString();
                lab_Correo_AreaPersonal.Text = usu.email.ToString();
            }
        }
    }
}