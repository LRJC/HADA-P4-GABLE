using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
	public class ENDirEnvio
	{ 	

		private string _usuario;
		public string usuario
        {
            get { return _usuario; }
			set { _usuario = value; }
        }

		private string _provincia;
		public string provincia
        {
			get { return _provincia; }
			set { _provincia = value; }
        }

		private string _pueblo;
		public string pueblo
        {
            get { return _pueblo; }
			set { _pueblo = value; }
        }

		private string _calle;
		public string calle
        {
            get { return _calle; }
			set { _calle = value; }
        }


		public ENDirEnvio()
		{
			usuario = "";
			provincia = "";
			pueblo = "";
			calle = "";
		}

		public ENDirEnvio(ENUsuario usu, ENLocalidad loc, string calle)
        {
			usuario = usu.dni;
			provincia = loc.provincia;
			pueblo = loc.pueblo;
			this.calle = calle;
        }

		public bool createDirEnvio()
        {
			CADDirEnvio dir = new CADDirEnvio();
			return dir.createDirEnvio(this);
        }

		public bool readDirEnvio()
        {
			CADDirEnvio dir = new CADDirEnvio();
			return dir.readDirEnvio(this);
		}

		public bool updateDirEnvio()
		{
			CADDirEnvio dir = new CADDirEnvio();
			return dir.updateDirEnvio(this);
		}

		public bool deleteDirEnvio()
		{
			CADDirEnvio dir = new CADDirEnvio();
			return dir.deleteDirEnvio(this);
		}

	}
}
