using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GableWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ShowBasketItems();
            }
        }

        private void ShowBasketItems()
        {
            string constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
            using (SqlConnection con = new SqlConnection(constring))
            {
                using(SqlCommand cmd = new SqlCommand("" +
                    "select p.nombre, lc.importe, lc.cantidad, lc.importe*lc.cantidad as total " +
                    "from linCest lc " +
                    "inner join producto p " +
                    "on lc.producto = p.id_producto " +
                    "inner join cesta c " +
                    "on c.numCesta = lc.numCesta and c.usuario = '20094272D'", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable linCestData = new DataTable();
                        sda.Fill(linCestData);
                        itemsCesta.DataSource = linCestData;
                        itemsCesta.DataBind();
                        double finalPrice = linCestData.Select().Sum(p => Convert.ToDouble(p["total"]));
                        (itemsCesta.Controls[itemsCesta.Controls.Count - 1].Controls[0].FindControl("totalPrice") as Label).Text = finalPrice.ToString() + "€";
                    }
                }
            }
        }
    }
}