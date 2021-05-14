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
                this.getListView();
            }
        }

        private void getListView()
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
        }
    }
}