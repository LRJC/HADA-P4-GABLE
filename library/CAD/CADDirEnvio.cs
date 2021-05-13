using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		public bool createDirEnvio(ENDirEnvio dir) { return false; }
		public bool readDirEnvio(ENDirEnvio dir) { return false; }
		public bool updateDirEnvio(ENDirEnvio dir) { return false; }
		public bool deleteDirEnvio(ENDirEnvio dir) { return false; }

	}
}
