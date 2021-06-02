using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace GableWeb
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCambiarDatosPersonales_Click(object sender, EventArgs e)
        {
            ENMarca mar = new ENMarca(TextBox1.Text,TextBox2.Text);
            mar.createMarca();

        }
    }
}