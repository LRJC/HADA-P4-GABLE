using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using library.EN;

namespace library.CAD
{
	public class CADDirEnvio
	{
		private string constring{ get; set;}

		public CADDirEnvio()
		{
			constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
		}

		public bool createDirEnvio(ENDirEnvio dir) {	//Tenemos un checkeo antes a priori
			bool retorno = false;
			using (SqlConnection c = new SqlConnection(constring))
            {
                try
                {
					c.Open();
					SqlCommand comprobar = new SqlCommand("Select * from dirEnvio where usuario = '" + dir.usuario + "' and provincia = '" + dir.provincia + "' and pueblo = '" + dir.pueblo + "' and calle = '" + dir.calle "'", c);
					SqlDataReader data = comprobar.ExecuteReader();
					if(data.Read()) return false;
					data.Close();

					SqlCommand com = new SqlCommand("Insert into dirEnvio (usuario, provincia, pueblo, calle) values ('" + dir.usuario + "', '" + dir.provincia + "', '" + dir.pueblo +"', '" + dir.calle + "')", c);
					com.ExecuteNonQuery();
					retorno = true;
                } 
				catch (Exception e)
                {
					Console.WriteLine($"Can't Create dirEnvio. Process Failed. Error : {0}", e.Message);
					return false;
                } 
				finally
                {
					c.Close();
                }
				
            }

			return retorno;
		}
		public bool readDirEnvio(ENDirEnvio dir) {
			bool retorno = false;
			using (SqlConnection c = new SqlConnection(constring))
            {
                try
                {
					c.Open();
					SqlCommand com = new SqlCommand("Select * from dirEnvio where usuario = '" + dir.usuario + "' and provincia = '" + dir.provincia + "' and pueblo = '" + dir.pueblo + "' and calle = '" + dir.calle "'", c);
					SqlDataReader data = com.ExecuteReader();
                
					while (data.Read())
					{
						dir.usuario = data["usuario"].ToString();
						dir.provincia = data["provincia"].ToString();
						dir.pueblo = data["pueblo"].ToString();
						dir.calle = data["calle"].ToString();
					}
					data.Close();
					retorno = true;
				} 
				catch (Exception e)
                {
					Console.WriteLine($"Can't Read dirEnvio. Process Failed. Error : {0}", e.Message);
					return false;
                } 
				finally
                {
					c.Close();
                }

            }
			return retorno;
		}

		public bool updateDirEnvio(ENDirEnvio dir) 
		{
			bool retorno = false;
			using (SqlConnection c = new SqlConnection(constring))
            {
				try
                {
					c.Open();
					SqlCommand com = new SqlCommand("Update usuario, provincia, pueblo, calle from dirEnvio set usuario = '" + dir.usuario + "' and provincia = '" + dir.provincia + "' and pueblo = '" + dir.pueblo + "' and calle = '" + dir.calle + "'", c);
					com.ExecuteNonQuery();
					retorno = true;
                }
				catch (Exception e)
                {
					Console.WriteLine($"Can't Update dirEnvio. Process Failed. Error : {0}", e.Message);
					return false;
                }
				finally
                {
					c.Close();
                }
            }
			return retorno;
		}
		public bool deleteDirEnvio(ENDirEnvio dir) 
		{
			bool retorno = false;
			using (SqlConnection c = new SqlConnection(constring))
            {
				try
                {
					c.Open();
					SqlCommand com = new SqlCommand("Delete * from dirEnvio where usuario usuario = '" + dir.usuario + "' and provincia = '" + dir.provincia + "' and pueblo = '" + dir.pueblo + "' and calle = '" + dir.calle + "'", c);
					com.ExecuteNonQuery();
					retorno = true;
                }
				catch (Exception e)
                {
					Console.WriteLine($"Can't Delete dirEnvio. Process Failed. Error : {0}", e.Message);
					return false;
                }
				finally
                {
					c.Close();
                }
            }
			return retorno;
		}

	}
}
