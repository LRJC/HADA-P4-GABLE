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
                ENMarca mar = new ENMarca(TextBox1.Text, TextBox2.Text);
                mar.modifyMarca();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {

                ENUsuario esu = new ENUsuario();
                esu.dni =Convert.ToString(  TextBox4.Text);
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
                ENProductos pr = new ENProductos();
                pr.id_producto = Convert.ToInt32(IDProd.Text);
                pr.nom_producto = NombreProd.Text;
                pr.desc_producto = DescProd.Text;
                pr.ImageLocation = imagenProd.Text;
                pr.tipo_producto = TipoProd.Text;
                pr.marca_producto = marcaProd.Text;
                pr.pre_producto = Convert.ToSingle(PrecioProd.Text);
                pr.createProducto();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }
    }
}