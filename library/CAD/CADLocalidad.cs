using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class CADLocalidad
    {
        private string constring;

        public CADLocalidad()
        {
            constring = ConfigurationManager.ConnectionStrings["miConexion"].ToString();
        }

        public bool createLocalidad(ENLocalidad loc)
        {
            return false;
        }
        
        public bool readLocalidad(ENLocalidad loc)
        {
            return false;
        }

        public bool updateLocalidad(ENLocalidad loc)
        {
            return false;
        }

        public bool deleteLocalidad(ENLocalidad loc)
        {
            return false;
        }
        
    }
}
