using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace library
{
    class CADUsuario
    {
        private string dbd;

        public CADUsuario()
        {
            dbd = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
        }

        public bool readUsuario(ENUsuario en)
        {
            bool devolver=false;
            using (SqlConnection c = new SqlConnection(dbd))
            {
                try
                {
                    c.Open();
                    String s = "Select * from usuario";
                    SqlCommand comando = new SqlCommand(s, c);
                    SqlDataReader data = comando.ExecuteReader();
                    while (data.Read())
                    {
                        if (data["dni"].ToString() == en.dni)
                        {
                            en.nombre = data["nombre"].ToString();
                            en.apellidos = data["apellidos"].ToString();
                            en.dni = data["dni"].ToString();
                            en.email = data["email"].ToString();
                            if (data["tarjeta"]!=null) {
                                en.numTarjeta = int.Parse(data["tarjeta"].ToString());
                            }
                            if (data["cvv_tarjeta"] != null) {
                                en.cvv = int.Parse(data["cvv_tarjeta"].ToString());
                            }
                            if (data["telefono"] != null) {
                                en.tlf = int.Parse(data["telefono"].ToString());
                            }
                            if (data["fecha_exp_tarjeta"] != null) {
                                en.expTarjeta = data["fecha_exp_tarjeta"].ToString();
                            }
                            if (data["nacido"] != null) {
                                en.fechanac = data["nacido"].ToString();//comprobar
                            }
                            devolver = true;
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("EXCEPCION");
                    devolver = false;
                }
                finally {
                    c.Close();
                }
            }
            return devolver;
        }

        public bool deleteUsuario(ENUsuario en)
        {
            SqlConnection c = new SqlConnection(dbd);
            try
            {
                c.Open();
                SqlCommand comando;
                comando = new SqlCommand("Delete usuario where dni='" + en.dni + "'", c);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("EXCEPCION");
                return false;
            }
            finally
            {
                c.Close();
            }
        }
        public bool createUsuario(ENUsuario en)
        {
            using (SqlConnection c = new SqlConnection(dbd))
            {
                using (SqlCommand comando = new SqlCommand("Insert into usuario(dni, nombre, apellidos, email, telefono, cvv_tarjeta, fecha_exp_tarjeta, nacido, tarjeta) values('" + en.dni + "', '" + en.nombre + "', '" + en.apellidos + "', '" + en.email + "', " + en.tlf + ", " + en.cvv + ", '" + en.expTarjeta + "', '" + en.fechanac + "', " + en.numTarjeta + ")", c))
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

        public bool updateUsuario(ENUsuario en)
        {
            using (SqlConnection c = new SqlConnection(dbd))
            {
                using (SqlCommand comando = new SqlCommand("Update usuario set contraseña='" + en.contraseña + "', email='" + en.email + "cvv_tarjeta = '" + en.cvv + "' , tlf = '" + en.tlf + "' where dni='" + en.dni + "'"))
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
    }
}
