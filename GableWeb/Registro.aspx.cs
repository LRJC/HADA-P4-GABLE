﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace GableWeb
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                ENUsuario user = new ENUsuario(dni.Text, nombre.Text, apellidos.Text, email.Text, pwd.Text, Convert.ToInt32(tlf.Text), date.Text);
                ENCesta c = new ENCesta();

                if (user.createUsuario())
                {
                    outputMsg.Text = "Usuario creado correctamente";
                    c.AddNewBasketForUser(dni.Text);
                    Response.Redirect("index.aspx");
                    
                }
                else outputMsg.Text = "No ha sido posible crear el usuario";
            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo al añadir el usuario");
            }
        }
    }
}