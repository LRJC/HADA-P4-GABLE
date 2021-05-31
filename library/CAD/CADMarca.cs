using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using library.EN;

namespace library.CAD
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
                String s = "Select * from marca";
                SqlCommand comando = new SqlCommand(s, c);
                SqlDataReader data;
                try
                {
                    c.Open();
                    data = comando.ExecuteReader();
                    while (data.Read())
                    {
                        if (data["nombre"].ToString() == en.nombre)
                        {
                            en.nombre = data["nombre"].ToString();
                            en.origen = data["origen"].ToString();
                            en.imagen = data["logo"].ToString();
                            devolver = true;
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("EXCEPCIÓN");
                    devolver = false;
                }
                finally
                {
                    c.Close();
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
                using (SqlCommand comando = new SqlCommand("Insert into marca(nombre, origen, logo) values('" + en.nombre + "', '" + en.origen + "', '" + en.imagen + "')", c))
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
            SqlConnection c = new SqlConnection(dbd);
            try
            {
                c.Open();
                SqlCommand comando = new SqlCommand("update marca set origen='"+en.origen+"' , logo='"+en.imagen+"' where nombre='"+en.nombre+"'");
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("EXCEPCION!!!!");
                return false;
            }
            finally
            {
                c.Close();
            }
        }
    }
}
