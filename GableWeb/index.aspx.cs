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
            }
        }

        /*private void getListView()
        {
            String conn = ConfigurationManager.ConnectionStrings["bbdd"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(conn);
            string sqlquery = "select * from producto";
            sqlconn.Open();
            SqlCommand command = new SqlCommand(sqlquery, sqlconn);
            SqlDataAdapter sqlda = new SqlDataAdapter(command);
            DataTable tab = new DataTable();
            sqlda.Fill(tab);
            gv1.DataSource = tab;
            gv1.DataBind();
            sqlconn.Close();
        }*/

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
                Console.WriteLine("Excepcion");
            }
            finally
            {
                sqlconn.Close();
            }
        }
    }
}