using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;
using library;

namespace GableWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["dni"] != null)
                {
                    Response.Redirect("index.aspx");
                }
            }
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            ENUsuario user = new ENUsuario();
            user.email = Login1.UserName;
            if(user.readUsuarioEmail())
            {
                if (user.contraseña == Login1.Password)
                {
                    Session.Add("dni", user.dni);
                    Response.Redirect("index.aspx");
                }
            }    
        }
    }
}