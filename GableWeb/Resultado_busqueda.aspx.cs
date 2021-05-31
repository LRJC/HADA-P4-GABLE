using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using library;


namespace GableWeb
{
    public partial class Resultado_busqueda : System.Web.UI.Page
    {
        private string categoria;
        protected void Page_Load(object sender, EventArgs e)
        {
            categoria = Request.QueryString["categoria_prod"];
            if (!IsPostBack)
            {
                loadProducts(categoria);
            }
        }

        protected void clickado(object sender, CommandEventArgs e)
        {
            Response.Redirect("Productos.aspx?id_prod=" + e.CommandArgument);
        }

        protected void loadProducts(string categoria)
        {
            try
            {
                ENProductos en = new ENProductos();
                DataTable tab = en.getProductTypeX(categoria);
                DataList1.DataSource = tab;
                DataList1.DataBind();
            }
            catch (Exception e)
            {
                Console.WriteLine("EXCEPCIÓN...");
            }
        }
    }
}