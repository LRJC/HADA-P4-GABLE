using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace GableWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private ENCesta cesta;
        protected void Page_Load(object sender, EventArgs e)
        {
            cesta = new ENCesta();
            if (Session["dni"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack && CheckIfSomeItem())
            {
                ShowBasketItems();
            }
        }

        private void ShowBasketItems()
        {
            DataTable linCestData = cesta.ShowBasketItems(Session["dni"].ToString());
            itemsCesta.DataSource = linCestData;
            itemsCesta.DataBind();
            double finalPrice = linCestData.Select().Sum(p => Convert.ToDouble(p["total"]));
            (itemsCesta.Controls[itemsCesta.Controls.Count - 1].Controls[0].FindControl("totalPrice") as Label).Text = finalPrice.ToString() + "€";
            
            bool thereAreItems = linCestData.Rows.Count > 0;
            itemsCesta.Visible = thereAreItems;
            AddItemToBasket.Visible = !thereAreItems;
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
        protected void ProceedToBuy(object sender, CommandEventArgs e)
        {
            int numCesta = 0;
            //te lo meto en un try catch para que no pete, pero soluciona la lógica pls
            try {
                numCesta = Convert.ToInt32(e.CommandArgument.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine($"error: {0}", ex.Message);
            }

            if (Session["LoggedIn"] == null)
            {
                if (CheckIfHaveBuyData(numCesta))
                {
                    InsertItemsIntoOrders(numCesta);
                    DeleteItemsFromBasket(numCesta);
                    Response.Redirect("index.asp");
                } else
                {
                    Response.Redirect("AreaPersonal_modData.aspx"); // Add data to buy
                }
            } else
            {
                Response.Redirect("Login.aspx");
            }
        }

        private void InsertItemsIntoOrders(int numCesta)
        {
            cesta.InsertItemsIntoOrders(numCesta);
        }

        private void DeleteItemsFromBasket(int numCesta)
        {
            cesta.DeleteItemsFromBasket(numCesta);
        }

        private bool CheckIfSomeItem()
        {
            return cesta.CheckIfSomeItem();
        }

        private bool CheckIfItemExists(int numCesta, int linea)
        {
            return cesta.CheckIfItemExists(numCesta, linea);
        }

        private bool CheckIfHaveBuyData(int numCesta)
        {
            ENCesta c = new ENCesta(numCesta);
            return c.CheckIfHaveBuyData(numCesta);
        }
    }
}