using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using library.EN;

namespace GableWeb
{
    public partial class Productos : System.Web.UI.Page
    {
        private string nomProd;

        protected void Page_Load(object sender, EventArgs e)
        {
            nomProd = Request.QueryString["id_prod"];
            
            getProduct(nomProd);
        }

        private void getProduct(string nomProd ) {

            ENProductos a = new ENProductos();
            
            try
            {        
                a.nom_producto = nomProd;
                a.readProducto();
                nombreP.Text = a.nom_producto;
                Image1.ImageUrl = a.ImageLocation;
                Desc.Text = a.desc_producto;
                Marca.Text = a.marca_producto;
                Precio.Text = Convert.ToString(a.pre_producto) + "€";

            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }             

        }
        protected void carrito(object sender, EventArgs e)
        {
            Response.Redirect("Cesta.aspx");
        }

        protected void comentario(object sender, EventArgs e)
        {
            if (Session["LoggedIn"]==null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                
            }



        }


    }
}