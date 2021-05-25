﻿using System;
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
    public partial class Resultado_busqueda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                getProduct();
            }
            
        }


        private void getProduct()
        {

            String conn = ConfigurationManager.ConnectionStrings["bbdd"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(conn);
            try
            {
                string sqlquery = "select * from producto where tipo_producto like 'pr1%'";
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


        protected void click_productos(object sender, CommandEventArgs e)
        {
            Response.Redirect("Productos.aspx?id_prod=" + e.CommandArgument);
        }
    }
}