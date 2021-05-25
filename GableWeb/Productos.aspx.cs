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
        private int id_prod;
        protected void Page_Load(object sender, EventArgs e)
        {
            nomProd = Request.QueryString["id_prod"];
            
            
             id_prod = Convert.ToInt32(nomProd);
            getProduct(id_prod);
            valo(id_prod);
        }

        private void getProduct(int id_prod)
        {

            ENProductos a = new ENProductos();

            try
            {
                a.id_producto = id_prod;
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

            ENLineaCesta lc = new ENLineaCesta();

            try
            {
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo al añadir producto en la cesta, ha saltado excepción...");
            }


            //Response.Redirect("Cesta.aspx");
        }

        private void valo(int id_prod)
        {

            ENProductos a = new ENProductos();
            ENValoraciones b = new ENValoraciones();

            try
            {
                a.id_producto = id_prod;
                a.readProducto();
                b.producto_id = id_prod;
                DataTable tab = b.showValo();            
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

                ENValoraciones a = new ENValoraciones();
                try
                {
                    a.producto_id = id_prod;
                    a.tex_val = msg.Value;
                    int val = Convert.ToInt32(botC.Value);
                    a.pun_val = val;
                    a.usuaro_id = User.Identity.Name;

                    switch (val)
                    {
                        case 1:
                            a.estr_val = "src/Estrella/estrella1.png";
                            break;

                        case 2:
                            a.estr_val = "src/Estrella/estrella2.png";
                            break;

                        case 3:
                            a.estr_val = "src/Estrella/estrella3.png";
                            break;

                        case 4:
                            a.estr_val = "src/Estrella/estrella4.png";
                            break;

                        case 5:
                            a.estr_val = "src/Estrella/estrella5.png";
                            break;
                    }

                    a.createValoracion();

                    Response.Redirect("Productos.aspx?id_prod=" + id_prod);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fallo en los comentarios, ha saltado excepción...");
                }
            }



        }


    }
}