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
    class CADUsuario
    {
        private string dbd;

        public CADUsuario()
        {
            //revisar->dbd = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }

        public bool readUsuario(ENUsuario en)
        {
            bool devolver = false;
            using (SqlConnection c = new SqlConnection(dbd))
            {
                String s = "Select * from usuario";
                SqlCommand comando = new SqlCommand(s, c);
                SqlDataReader data = comando.ExecuteReader();
                while (data.Read())
                {
                    if (data["dni"].ToString() == en.nif)
                    {
                        en.nombre = data["nombre"].ToString();
                        en.apellidos = data["apellidos"].ToString();
                        en.nif = data["dni"].ToString();
                        en.email = data["email"].ToString();
                        en.contraseña = data["contraseña"].ToString();
                        en.numTarjeta = int.Parse(data["tarjeta"].ToString());
                        en.cvv = int.Parse(data["cvv_tarjeta"].ToString());
                        en.tlf = int.Parse(data["tlf"].ToString());
                        en.expTarjeta = data["fecha_exp_tarjeta"].ToString();
                        en.fechanac= data["fechanac"].ToString();//comprobar
                        devolver = true;
                        break;
                    }
                }
                data.Close();
            }
            return devolver;
        }

        public bool deleteUsuario(ENUsuario en)
        {
            using (SqlConnection c = new SqlConnection(dbd))
            {
                using (SqlCommand comando = new SqlCommand("Delete * from usuario where dni=" + en.nif))
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
        public bool createUsuario(ENUsuario en)
        {
            using (SqlConnection c = new SqlConnection(dbd))
            {
                using (SqlCommand comando = new SqlCommand("Insert into usuario(dni, nombre, apellidos, email, tlf, cvv_tarjeta, fecha_exp_tarjeta, fecha_nac, tarjeta, contraseña ) values('" + en.nif + "', '" + en.nombre + "', '" + en.apellidos + "', "+en.email + "', '" + en.tlf + "', '" + en.cvv + "', '" + en.expTarjeta + "', '" + en.fechanac + "', '" + en.numTarjeta + "', " + en.contraseña+"')", c))
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
                using (SqlCommand comando = new SqlCommand("Update marca set origen='" + en.origen + "', logo='" + en.imagen + "' where nombre='" + en.nombre + "'"))
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

    public bool loginUsuario(ENUsuario en)
        {
            //implementación(validación de contraseña y usuario, ...)
            return true;
        }

        public bool logoutUsuario(ENUsuario en)//revisar
        {
            //implementación
            return true;
        }

        public bool subirProducto(ENUsuario en)//revisar
        {
            //implementación
            return true;
        }

        public bool deleteProducto(ENUsuario en)//revisar
        {
            //implementación
            return true;
        }
    }
}
