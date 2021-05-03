using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
	public class CADTipoProducto
	{
		private string constring { get; set; }

		public CADTipoProducto()
		{
			constring = ConfigurationManager.ConnectionStrings["miConexion"].ToString();
		}

		public bool createTipoProducto(ENTipoProducto tip) { return false; }
		public bool readTipoProducto(ENTipoProducto tip) { return false; }
		public bool updateTipoProducto(ENTipoProducto tip) { return false; }
		public bool deleteTipoProducto(ENTipoProducto tip) { return false; }
	}

}
