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
            /*if (!IsPostBack)
            {
                if (Session["dni"] != null)//si esta loggeado
                {
                    if(Session["dni"].ToString() != "00000000A")//si no es el admin
                    {
                        Response.Redirect("index.aspx");
                    }
                }
                else//si no esta loggeado
                {
                    Response.Redirect("Login.aspx");
                }
                
            }*/
        }

        protected void ButtonCambiarDatosPersonales_Click(object sender, EventArgs e)
        {
            ENMarca mar = new ENMarca();
            bool dev;
            bool read;
            try
            {
                if (TextBox3.Text!="")
                {
                    salidaMarcas.Text = "El campo nombre actual no es necesario rellenarlo. Vuelva a introducir los datos";
                }
                else {
                    mar.nombre = TextBox1.Text;
                    mar.origen = TextBox2.Text;
                    if (TextBox1.Text == "" || TextBox2.Text == "")
                    {
                        salidaMarcas.Text = "Los campos nombre nuevo y origen son obligatorios.";
                    }
                    else {
                        read = mar.readMarca();
                        if (read)
                        {
                            salidaMarcas.Text = "La marca no se ha podido crear.";
                        }
                        else
                        {
                            dev = mar.createMarca();
                            if (dev)
                            {
                                salidaMarcas.Text = "Marca creada correctamente.";
                            }
                            else
                            {
                                salidaMarcas.Text = "La marca no se ha podido crear.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ENMarca mar = new ENMarca();
            bool dev;
            mar.nombre = TextBox3.Text;
            try
            {
                if (TextBox2.Text!=""||TextBox1.Text!="")
                {
                    salidaMarcas.Text = "Los campos nombre nuevo y origen no son ncesarios. Introduzca los datos en nombre actual.";
                }
                else {
                    if (TextBox3.Text == "")
                    {
                        salidaMarcas.Text = "El campo nombre actual es obligatorio";
                    }
                    else
                    {
                        dev = mar.deleteMarca();
                        if (dev)
                        {
                            salidaMarcas.Text = "Marca Eliminada correctamente.";
                        }
                        else
                        {
                            salidaMarcas.Text = "La marca no se ha podido eliminar o no existe.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            bool dev;
            try
            {
                if (TextBox1.Text==""||TextBox2.Text==""||TextBox3.Text=="") {
                    salidaMarcas.Text = "Los tres campos son obligatorios";
                }
                else
                {
                    ENMarca mar = new ENMarca(TextBox3.Text, TextBox2.Text);
                    dev = mar.modifyMarca(TextBox1.Text);
                    if (dev)
                    {
                        salidaMarcas.Text = "Marca modificada correctamente.";
                    }
                    else
                    {
                        salidaMarcas.Text = "La marca no se ha podido modificar o no existe.";
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            bool dev;
            
            try
            {
                if (TextBox4.Text=="")
                {
                    salidaElim.Text = "El campo DNI es obligatorio.";
                }
                else {
                    ENUsuario esu = new ENUsuario();
                    esu.dni = TextBox4.Text.ToString();
                    esu.deleteCestaUsu();
                    esu.deleteValUsu();
                    esu.deletePedidoFromUsu();
                    dev = esu.deleteUsuario();
                    if (dev)
                    {
                        salidaElim.Text = "Usuario eliminado correctamente.";
                    }
                    else
                    {
                        salidaElim.Text = "El usuario no se ha podido eliminar o no existe.";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        protected void crearProd_Click(object sender, EventArgs e)
        {
            bool dev;
            try
            {
                if (IDProd.Text==""||marcaProd.Text==""|| TipoProd.Text == "" || imagenProd.Text == "" || DescProd.Text == "" || PrecioProd.Text == "")
                {
                    salidaProd.Text = "Todos los campos son obligatorios.";
                }
                else {
                    ENProductos pr = new ENProductos();
                    pr.id_producto = int.Parse(IDProd.Text);
                    pr.nom_producto = NombreProd.Text;
                    pr.desc_producto = DescProd.Text;
                    pr.ImageLocation = imagenProd.Text;
                    pr.tipo_producto = TipoProd.Text;
                    pr.marca_producto = marcaProd.Text;
                    pr.pre_producto = float.Parse(PrecioProd.Text);
                    dev = pr.createProducto();
                    if (dev)
                    {
                        salidaProd.Text = "Producto creado correctamente.";
                    }
                    else
                    {
                        salidaProd.Text = "El producto no se ha podido crear.";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fallo en el programa, ha saltado excepción...");
            }
        }

        protected void elimProd_Click(object sender, EventArgs e)
        {
            ENProductos pr = new ENProductos();
            bool dev;
            pr.id_producto= Convert.ToInt32(IDProd.Text);
            try
            {
                if (marcaProd.Text!=""||imagenProd.Text!=""||TipoProd.Text!=""||PrecioProd.Text!=""||DescProd.Text!=""||NombreProd.Text!="")
                {
                    salidaProd.Text = "El único campo necesario para eliminar es ID producto. Introduzca los datos en el campo mencionado.";
                }
                else {
                    if (IDProd.Text == "")
                    {
                        salidaProd.Text = "Campo ID producto es obligatorio.";
                    }
                    else {
                        dev = pr.deleteProductos();
                        if (dev)
                        {
                            salidaProd.Text = "Producto eliminado correctamente.";
                        }
                        else
                        {
                            salidaProd.Text = "El producto no se ha podido eliminar o no existe.";
                        }
                    }
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("EXCEPCIÓN");
            }
        }

        protected void modProd_Click(object sender, EventArgs e)
        {
            bool dev;
            try
            {
                if (IDProd.Text == "" || marcaProd.Text == "" || TipoProd.Text == "" || imagenProd.Text == "" || DescProd.Text == "" || PrecioProd.Text == "")
                {
                    salidaProd.Text = "Todos los campos son obligatorios.";
                }
                else
                {
                    ENProductos pr = new ENProductos();
                    pr.id_producto = int.Parse(IDProd.Text);
                    pr.nom_producto = NombreProd.Text;
                    pr.desc_producto = DescProd.Text;
                    pr.ImageLocation = imagenProd.Text;
                    pr.tipo_producto = TipoProd.Text;
                    pr.marca_producto = marcaProd.Text;
                    pr.pre_producto = float.Parse(PrecioProd.Text);
                    dev = pr.updateProductos();
                    if (dev)
                    {
                        salidaProd.Text = "Producto modificado correctamente.";
                    }
                    else
                    {
                        salidaProd.Text = "El producto no se ha podido modificar o no existe.";
                    }
                }
            }
            catch (Exception er)
            {
                Console.WriteLine("EXCEPCIOOON");
            }

        }
    }
}