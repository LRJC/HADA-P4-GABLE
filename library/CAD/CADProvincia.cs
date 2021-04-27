using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class CADProvincia
    {
        private string constring;

        public CADProvincia()
        {
            constring = ConfigurationManager.ConnectionStrings["miConexion"].ToString();
        }

        public bool createProvincia(ENProvincia en)
        {
            return false;
        }

        public bool readProvincia(ENProvincia en)
        {
            return false;
        }

        public bool updateProvincia(ENProvincia en)
        {
            return false;
        }

        public bool deleteProvincia(ENProvincia en)
        {
            return false;
        }

    }
}
