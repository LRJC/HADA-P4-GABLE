using System;
using library.EN;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Threading.Tasks;

namespace library.CAD
{
    class CADProductos
    {
        private string constring;

        public CADProductos()
        {
            constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
        }
        public bool readProductos(ENProductos en)
        {


            SqlConnection con = new SqlConnection(constring);

            try
            {
                con.Open();

                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand("Select nombre, descripción,tipo_producto, precio, imagen,marca,id_producto from producto where nombre='" + en.nom_producto + "'", con);
                SqlDataReader reader = data.SelectCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    en.nom_producto = reader.GetString(0);
                    en.desc_producto = reader.GetString(1);
                    en.tipo_producto = reader.GetString(2);
                    en.ImageLocation = reader.GetString(4);
                    en.marca_producto = reader.GetString(5);
                    en.id_producto = reader.GetInt32(6);

                    double pre = reader.GetDouble(3);
                    en.pre_producto = Convert.ToSingle(pre);
                }
                else
                {

                    Console.WriteLine("Product operation has failed. Error:Cant found the id");
                    throw new Exception("ERROR:El id del producto no ha sido encontrado");
                }
                reader.Close();

            }
            catch (SqlException ex)
            {

                Console.WriteLine("Product operation has failed. Error: {0}", ex.Message);
                throw new Exception("Product operation has failed. Error: {0}" + ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }

            return true;
        }

        public bool createProductos(ENProductos en)
        {

            SqlConnection con = new SqlConnection(constring);

            try
            {
                con.Open();

                if (exist(en, con))
                {
                    Console.WriteLine("Product operation failed. Error: Product already exist");
                    throw new Exception("ERROR: Ya hay un producto con el mismo id");
                }

                //Query
                string query = "Insert into producto (id_producto ,nombre, descripción, precio, imagen, tipo_producto, marca) values ('" + en.id_producto + "'" + en.nom_producto + "'" + en.desc_producto + "'" + en.pre_producto + "'" + en.ImageLocation + "'" + en.tipo_producto + "'" + en.marca_producto + ")";
                SqlDataAdapter data = new SqlDataAdapter();
                data.InsertCommand = new SqlCommand(query, con);
                data.InsertCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                Console.WriteLine("Product operation failed. Error:{0}", ex.Message);
                throw new Exception("Product operation failed. Error: " + ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }

            return true;
        }

        public bool deleteProductos(ENProductos en)
        {

            SqlConnection con = new SqlConnection(constring);

            try
            {

                con.Open();
                if (!exist(en, con))
                {
                    Console.WriteLine("Product operation failed. Error: Product already exist");
                    throw new Exception("ERROR: Ya hay un producto con el mismo id");
                }
                SqlDataAdapter data = new SqlDataAdapter();
                data.DeleteCommand = new SqlCommand("Delete producto where id='" + en.id_producto + "'", con);
                data.DeleteCommand.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Product operation failed. Error:{0}", ex.Message);
                throw new Exception("Product operation failed. Error: " + ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }

            return true;
        }

        public bool updateProductos(ENProductos en)
        {

            SqlConnection con = new SqlConnection(constring);

            try
            {

                con.Open();
                if (!exist(en, con))
                {
                    Console.WriteLine("Product operation failed. Error: Product already exist");
                    throw new Exception("ERROR: Ya hay un producto con el mismo id");
                }
                SqlDataAdapter data = new SqlDataAdapter();
                data.UpdateCommand = new SqlCommand("Update producto set nombre='" + en.nom_producto + "',descripcion=" + en.desc_producto + "', precio=" + en.pre_producto + "',imagen=" + en.ImageLocation + "',tipo_producto=" + en.tipo_producto + "', marca=" + en.marca_producto + "' where id= " + en.id_producto + "'", con);
                data.UpdateCommand.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine("Product operation failed. Error:{0}", ex.Message);
                throw new Exception("Product operation failed. Error: " + ex.Message);
            }
            finally
            {
                if (con != null) con.Close();
            }

            return true;
        }

        private bool exist(ENProductos en, SqlConnection con)
        {
            SqlDataAdapter data = new SqlDataAdapter();
            data.SelectCommand = new SqlCommand("Select * from producto where id='" + en.id_producto + "'", con);
            int i = data.SelectCommand.ExecuteNonQuery();
            return (null != data.SelectCommand.ExecuteScalar());
        }
    }
}
