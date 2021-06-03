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

        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool auth = false;
            auth = LoginCorrecto(Login1.UserName, Login1.Password);
            e.Authenticated = auth;
            if (auth)
                
                Response.Redirect("index.aspx");
        }
        private bool LoginCorrecto(string email, string pwd)
        {
            if (email.Equals("alex@gmail.com") && pwd.Equals("alex"))
                return true;

            return false;
        }
    }
}