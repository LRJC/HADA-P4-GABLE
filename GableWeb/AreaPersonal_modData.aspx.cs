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
            usu.dni = dni;
            if (!usu.readUsuario())//no existe el usuario de la sesión actual
            {
                Session.RemoveAll();
                Session.Abandon();
                Response.Redirect("Login.aspx");
            }
            else
            {
                lab_NombreApellidos_AreaPersonal_mod.Text = usu.nombre.ToString() + " " + usu.apellidos.ToString();
                lab_Dni_AreaPersonal_mod.Text = usu.dni.ToString();
                lab_Correo_AreaPersonal_mod.Text = usu.email.ToString();
                if(usu.numTarjeta.ToString() != "")
                {
                    LabelTarjeta.Text = usu.numTarjeta.ToString();
                }
                else
                {
                    LabelTarjeta.Text = "No tienes tarjeta todavía";
                }
            }
        }

        protected void ButtonCambiarContra_Click(object sender, EventArgs e)
        {
            if (requiredOldPwd.IsValid && requiredNewPwd.IsValid && requiredConfirmPwd.IsValid && compareContras.IsValid)
            {
                ENUsuario usu = new ENUsuario();
                usu.dni = Session["dni"].ToString();
                usu.readUsuario();
                usu.contraseña = newPasswd.Text;
                usu.updateUsuario();

                //notificar que todo ha ido bien
            }
        }

        protected void ButtonCambiarDatosPersonales_Click(object sender, EventArgs e)
        {
            if (regexEmail.IsValid && regexFecNac.IsValid && regexTlf.IsValid) {
                ENUsuario usu = new ENUsuario();
                usu.dni = Session["dni"].ToString();
                usu.readUsuario();

                if (TextBoxModEmail.Text.ToString() != "")
                {
                    usu.email = TextBoxModEmail.Text.ToString();
                }

                if (TextBoxModEmail.Text.ToString() != "")
                {
                    usu.nombre = TextBoxModNombre.Text.ToString();
                }

                if (TextBoxModApellidos.Text.ToString() != "")
                {
                    usu.apellidos = TextBoxModApellidos.Text.ToString();
                }

                if (TextBoxModFecNac.Text.ToString() != "")
                {
                    usu.fechanac = TextBoxModFecNac.Text.ToString();
                }

                if (TextBoxModTlf.Text.ToString() != "")
                {
                    usu.tlf = Convert.ToInt32(TextBoxModTlf.Text);
                }

                usu.updateUsuario();
            }

            //notificar que todo ha ido bien

        }

        protected void ButtonCambiarInfoPagos_Click(object sender, EventArgs e)
        {
            Response.Redirect("DatosPago.aspx");
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("index.aspx");
        }

        protected void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            ENUsuario usu = new ENUsuario();
            usu.dni = Session["dni"].ToString();
            usu.deleteCestaUsu();
            usu.deleteDirEnvioUsu();
            usu.deletePedidoFromUsu();
            usu.deleteValUsu();
            usu.deleteUsuario();
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("index.aspx");
        }
    }
}