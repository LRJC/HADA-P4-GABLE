using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library.EN;

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
                    "select p.nombre, p.imagen, lc.numCesta, lc.linea, " +
                    "lc.importe, lc.cantidad, lc.importe*lc.cantidad as total " +
                    "from linCest lc " +
                    "inner join producto p " +
                    "on lc.producto = p.id_producto " +
                    "inner join cesta c " +
                    "on c.numCesta = lc.numCesta and c.usuario = '20094273D'", con))
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

        protected void ItemQuery(object sender, CommandEventArgs e)
        {
            string[] args = e.CommandArgument.ToString().Split(',');
            int numCesta = Convert.ToInt32(args[0]);
            int linea = Convert.ToInt32(args[1]);

            if(CheckIfItemExists(numCesta, linea))
            {
                ENLineaCesta lc = new ENLineaCesta(numCesta, linea);
                switch(e.CommandName)
                {
                    case "RemoveItemFromBasket":
                        if (lc.removeItem())
                            Response.Redirect("Cesta.aspx");
                        break;
                    case "SubstractItemQuantity":
                        if(lc.substrUnit())
                            Response.Redirect("Cesta.aspx");
                        break;
                    case "AddItemQuantity":
                        if (lc.addUnit())
                            Response.Redirect("Cesta.aspx");
                        break;
                }
            }
        }

        private bool CheckIfItemExists(int numCesta, int linea)
        {
            string constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("" +
                    "select * " +
                    "from linCest " +
                    "where numCesta = " + numCesta + " and linea = " + linea +
                    "", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable linCestData = new DataTable();
                        sda.Fill(linCestData);

                        return linCestData.Rows.Count > 0;
                    }
                }
            }
        }
    }
}