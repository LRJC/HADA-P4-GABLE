using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace GableWeb
{
    public partial class AreaPersonal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session.Add("dni", "1234");
                if (Session["dni"] != null)
                {
                    setClientArea(Session["dni"].ToString());
                    loadPedidos();
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }


            }
        }

        protected void loadPedidos()
        {
            try
            {
                ENPedido ped = new ENPedido();
                DataTable pedidos = ped.getPedidos(Session["dni"].ToString());
                dataListPedidos.DataSource = pedidos;
                dataListPedidos.DataBind();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Excepción en loadPedidos. Error: {0}", ex.Message);
            }
        }

        protected void setClientArea(string dni)
        {
            ENUsuario usu = new ENUsuario();
            usu.dni = dni;
            if (usu.readUsuario())//existe el usuario de la sesión actual
            {
                lab_NombreApellidos_AreaPersonal.Text = usu.nombre.ToString() + " " + usu.apellidos.ToString();
                lab_Dni_AreaPersonal.Text = usu.dni.ToString();
                lab_Correo_AreaPersonal.Text = usu.email.ToString();
            }
            else
            {
                Session.RemoveAll();
                Session.Abandon();
                Response.Redirect("index.aspx");
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("index.aspx");
        }

        protected void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            ENUsuario usu = new ENUsuario();
            usu.dni = Session["dni"].ToString();
            usu.deleteUsuario();
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("index.aspx");
        }

        protected void verDetallesPed_Click(object sender, CommandEventArgs e)
        {
            Response.Redirect("pedidos.aspx?pedido=" + e.CommandArgument);
        }
    }
}