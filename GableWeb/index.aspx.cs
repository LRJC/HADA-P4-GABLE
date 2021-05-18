using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GableWeb
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.getMostSold();
                this.getBetteReviewed();
                this.getRecommended();
            }
        }

        private void getRecommended()
        {
            String conn = ConfigurationManager.ConnectionStrings["bbdd"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(conn);
            try
            {
                string sqlquery = "select top 6 * from producto";
                sqlconn.Open();
                SqlCommand command = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sqlda = new SqlDataAdapter(command);
                DataTable tab = new DataTable();
                sqlda.Fill(tab);
                gv2.DataSource = tab;
                gv2.DataBind();
            }
            catch (Exception e)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void getMostSold()
        {
            String conn = ConfigurationManager.ConnectionStrings["bbdd"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(conn);
            try
            {
                string sqlquery = "select top 6 p.nombre, p.precio, p.imagen, sum(l.cantidad) from producto p, linPed l where l.producto=p.id_producto group by p.id_producto, p.nombre, p.precio, p.imagen order by sum(cantidad) desc";
                sqlconn.Open();
                SqlCommand command = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sqlda = new SqlDataAdapter(command);
                DataTable tab = new DataTable();
                sqlda.Fill(tab);
                gv1.DataSource = tab;
                gv1.DataBind();
            }
            catch (Exception e)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void getBetteReviewed()
        {
            String conn = ConfigurationManager.ConnectionStrings["bbdd"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(conn);
            try
            {
                string sqlquery = "select top 6 p.nombre, p.precio, p.imagen, avg(v.puntuación) from producto p, valoracion v where v.producto=p.id_producto group by p.id_producto, p.imagen, p.nombre, p.precio order by avg(v.puntuación) desc";
                sqlconn.Open();
                SqlCommand command = new SqlCommand(sqlquery, sqlconn);
                SqlDataAdapter sqlda = new SqlDataAdapter(command);
                DataTable tab = new DataTable();
                sqlda.Fill(tab);
                gv3.DataSource = tab;
                gv3.DataBind();
            }
            catch (Exception e)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
            finally
            {
                sqlconn.Close();
            }
        }

        protected void click_productos(object sender, CommandEventArgs e)
        {
            Response.Redirect("Productos.aspx?id_prod="+e.CommandArgument);
        }

    }
}