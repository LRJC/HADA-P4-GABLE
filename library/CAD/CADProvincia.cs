using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using library;

namespace library
{
    public class CADProvincia
    {
        private string constring;

        public CADProvincia()
        {
            constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
        }

        public bool createProvincia(ENProvincia en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                //comprobamos que no exista
                SqlCommand com1 = new SqlCommand("select * from provincia where codp = '" + en.codp.ToString() + "'", c);
                SqlDataReader dr = com1.ExecuteReader();

                if (dr.Read()) return false; //ya existia

                SqlCommand com2 = new SqlCommand("insert into provincia(codp,nombre) values ('" + en.codp.ToString() + "','" + en.nombre.ToString() + "')", c);
                com2.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Create provincia failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public bool readProvincia(ENProvincia en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("select * from provincia where codp = '" + en.codp + "';", c);

                SqlDataReader dr = com.ExecuteReader();

                if (dr.Read())
                {
                    en.codp = dr["codp"].ToString();
                    en.nombre= dr["nombre"].ToString();
                    return true;

                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Read provincia failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public bool updateProvincia(ENProvincia en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                if (en.codp.ToString() != "")//comprobamos que no esté vacío el campo
                {
                    SqlCommand com1 = new SqlCommand("update provincia set nombre = '" + en.nombre.ToString() + "' where codp = '" + en.codp.ToString() + "';", c);
                    if (com1.ExecuteNonQuery() != 0) return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Update provincia failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public bool deleteProvincia(ENProvincia en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                SqlCommand com = new SqlCommand("delete from provincia where codp = '" + en.codp.ToString() + "';", c);

                if (com.ExecuteNonQuery() == 0) return false;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Delete provincia failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

    }
}
