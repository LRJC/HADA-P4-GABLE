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
            valo(nomProd);
        }

        private void getProduct(string nomProd)
        {

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

        private void valo(string nomProd)
        {

            ENProductos a = new ENProductos();
            ENValoraciones b = new ENValoraciones();

            String conn = ConfigurationManager.ConnectionStrings["bbdd"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(conn);

            try
            {
                a.nom_producto = nomProd;
                a.readProducto();
                int id_prod = a.id_producto;

                b.producto_id = id_prod;
                b.readAuxValoraciones();
                string usu = b.usuaro_id;



                string sqlquery = "select u.nombre, v.texto ,v.puntuación from usuario u, valoracion v where v.usuario='" + usu + "' and u.dni='" + usu + "' and v.producto='" + id_prod + "'";
                sqlconn.Open();
                SqlCommand command = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sqlda = new SqlDataAdapter(command);
                DataTable tab = new DataTable();
                sqlda.Fill(tab);
                gv1.DataSource = tab;
                gv1.DataBind();




            }
            catch (Exception ex)
            {

                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }

        }



        protected void comentario(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {

            }



        }


    }
}