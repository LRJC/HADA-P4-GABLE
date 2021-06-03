using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace GableWeb
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCambiarDatosPersonales_Click(object sender, EventArgs e)
        {
            ENMarca mar = new ENMarca();
            try
            {
                mar.nombre = TextBox1.Text;
                mar.origen = TextBox2.Text;
                mar.createMarca();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ENMarca mar = new ENMarca();
            mar.nombre = TextBox1.Text;
            try
            {
                if (TextBox1.Text == "") throw new Exception("El campo Nombre esta vacio");
                mar.deleteMarca();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ENMarca mar = new ENMarca(TextBox3.Text, TextBox2.Text);
                mar.modifyMarca(TextBox1.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ENUsuario esu = new ENUsuario();
            esu.dni = TextBox4.Text.ToString();
            try
            {
                esu.deleteCestaUsu();
                esu.deleteValUsu();
                esu.deletePedidoFromUsu();
                esu.deleteUsuario();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        protected void crearProd_Click(object sender, EventArgs e)
        {
            try
            {
                ENProductos pr = new ENProductos(int.Parse(IDProd.Text), NombreProd.Text, DescProd.Text, float.Parse(PrecioProd.Text), imagenProd.Text, TipoProd.Text, marcaProd.Text);
                pr.createProducto();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        protected void elimProd_Click(object sender, EventArgs e)
        {
            ENProductos pr = new ENProductos();
            pr.id_producto = int.Parse(IDProd.Text);
            pr.deleteProductos();
        }

        protected void modProd_Click(object sender, EventArgs e)
        {
            ENProductos pr = new ENProductos();
            pr.updateProductos();
        }
    }
}