using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    class CADMarca
    {
        private string dbd;

        public CADMarca()
        {
            dbd = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
        }
        public bool readMarca(ENMarca en)
        {
            bool devolver=false;
            using (SqlConnection c = new SqlConnection(dbd)) {
                c.Open();
                String s = "Select * from marca";
                SqlCommand comando = new SqlCommand(s, c);
                SqlDataReader data = comando.ExecuteReader();
                while (data.Read())
                {
                    if (data["nombre"].ToString() == en.nombre)
                    {
                        en.nombre = data["nombre"].ToString();
                        en.origen = data["origen"].ToString();
                        devolver = true;
                        break;
                    }
                }
            }
            return devolver;
        }

        public bool deleteMarca(ENMarca en)
        {
            SqlConnection c = new SqlConnection(dbd);
            try
            {
                c.Open();
                SqlCommand comando;
                comando = new SqlCommand("Delete from marca where nombre='" + en.nombre + "'", c);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("EXCEPCION");
                return false;
            }
            finally {
                c.Close();
            }
        }
        public bool createMarca(ENMarca en)
        {
            using (SqlConnection c = new SqlConnection(dbd))
            {
                using (SqlCommand comando = new SqlCommand("Insert into marca(nombre, origen) values('" + en.nombre + "', '" + en.origen + "')", c))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(comando))
                    {
                        try
                        {
                            c.Open();
                            comando.ExecuteNonQuery();
                            c.Close();
                            return true;
                        }
                        catch (Exception e)
                        {
                            return false;
                        }
                    }
                }
            }
        }

        public bool modifyMarca(ENMarca en)
        {
            bool devolver;
            SqlConnection con = new SqlConnection(dbd);

            try
            {
                con.Open();
                SqlCommand comando = new SqlCommand("Update marca set origen='" + en.origen + "' where nombre='" + en.nombre + "'", con);
                comando.ExecuteNonQuery();
                devolver = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Brand operation failed");
                devolver = false;
            }
            finally
            {
                if (con != null) con.Close();
            }

            return devolver;
        }
    }
}
