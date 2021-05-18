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
			constring = ConfigurationManager.ConnectionStrings["miConexion"].ToString();
		}

		public bool createDirEnvio(ENDirEnvio dir) {	//Tenemos un checkeo antes a priori
			bool retorno = false;
			using (SqlConnection c = new SqlConnection(constring))
            {
				SqlCommand com = new SqlCommand("");
            }

			return retorno;
		}
		public bool readDirEnvio(ENDirEnvio dir) {
			bool retorno = false;
			using (SqlConnection c = new SqlConnection(constring))
            {
				SqlCommand com = new SqlCommand("");
				SqlDataReader data = com.ExecuteReader();

                while (data.Read())
                {

                }

				data.Close();

            }
			return retorno;
		}

		public bool updateDirEnvio(ENDirEnvio dir) { return false; }
		public bool deleteDirEnvio(ENDirEnvio dir) { return false; }

	}
}
