using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library.EN;

namespace library.CAD;
{
	public class CADTipoProducto
	{
		private string constring { get; set; }

		public CADTipoProducto()
		{
			constring = ConfigurationManager.ConnectionStrings["miConexion"].ToString();
		}

		public bool createTipoProducto(ENTipoProducto tip) {
			bool retorno = false;
			using (SqlConnection c = new SqlConnection(constring))
            {
				try
                {
					c.Open();
					SqlCommand com = new SqlCommand("Insert into tipo_producto (tipo_producto) values ('" + tip.tipo_producto + "')", c);
					com.ExecuteNonQuery();
					retorno = true;

                } catch (Exception e)
                {
					return false;
                } finally
                {
					c.Close();
                }
                
            }
			return retorno;
		}
		public bool readTipoProducto(ENTipoProducto tip) {
			bool retorno = false;
			using (SqlConnection c = new SqlConnection(constring))
            {
				try
				{
					c.Open();
					SqlCommand com = new SqlCommand("Select * from tipo_producto where tipo_producto = '" + tip.tipo_producto + "'", c);
					SqlDataReader data = com.ExecuteReader();

                    while (data.Read())
                    {
						tip.tipo_producto = data["tipo_producto"].ToString();
                    }

					data.Close();
					retorno = true;
				} catch (Exception e)
                {
					return false;
                } finally
                {
					c.Close();
                }
            }
			return retorno;
		}
		public bool updateTipoProducto(ENTipoProducto tip)
		{
			bool retorno = false;
			using (SqlConnection c = new SqlConnection(constring))
            {
                try
                {
					c.Open();
					SqlCommand com = new SqlCommand("Update tipo_producto from tipo_producto set tipo_producto = '" + tip.tipo_producto + "'", c);
					com.ExecuteNonQuery();
					retorno = true;
                } catch (Exception e)
                {
					return false;
                } finally
                {
					c.Close();
                }
            }
			return retorno;
		}
	
		public bool deleteTipoProducto(ENTipoProducto tip) 
		{
			bool retorno = false;
			using (SqlConnection c = new SqlConnection(constring))
            {
                try
                {
					c.Open();
					SqlCommand com = new SqlCommand("Delete * from tipo_producto where tipo_producto = '" + tip.tipo_producto + "'", c);
					com.ExecuteNonQuery();
					retorno = true;
                } catch (Exception e)
                {
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
