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
    class CADMarca
    {
        private string dbd;

        public CADMarca()
        {
            //revisar->dbd = ConfigurationManager.ConnectionStrings["miconexion"].ToString();
        }
        public bool readMarca(ENMarca en)
        {
            //implementación
            return true;
        }

        public bool deleteMarca(ENMarca en)
        {
            //implementación
            return true;
        }
        public bool createMarca(ENMarca en)
        {
            //implementación
            return true;
        }

        public bool modifyMarca(ENMarca en)
        {
            //implementación
            return true;
        }
    }
}
