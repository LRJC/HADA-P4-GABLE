using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using library.CAD;
using library.EN;

namespace GableWeb
{
    public partial class index : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.getMostSold2();
                this.getBetteReviewed2();
                this.getRecommended2();
            }
        }

        private void getRecommended2()
        {
            try
            {
                ENProductos p = new ENProductos();
                DataTable tab = p.getRecommended();
                gv2.DataSource = tab;
                gv2.DataBind();
            }
            catch (Exception e)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        private void getMostSold2()
        {
            try
            {
                ENProductos p = new ENProductos();
                DataTable tab = p.getMostSold();
                gv1.DataSource = tab;
                gv1.DataBind();
            }
            catch (Exception e)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        private void getBetteReviewed2()
        {
            try
            {
                ENProductos p = new ENProductos();
                DataTable tab = p.getBetterReviewed();
                gv3.DataSource = tab;
                gv3.DataBind();
            }
            catch (Exception e)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        protected void click_productos(object sender, CommandEventArgs e)
        {
            Response.Redirect("Productos.aspx?id_prod="+e.CommandArgument);
        }

    }
}