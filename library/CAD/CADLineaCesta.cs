using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library.EN;

namespace library.CAD
{
    class CADLineaCesta
    {
        private string constring;

        public CADLineaCesta()
        {
            constring = ConfigurationManager.ConnectionStrings["conexion"].ToString();
        }

        public bool addUnit(ENLineaCesta lc) { return false; }

        public bool removeUnit(ENLineaCesta lc) { return false; }

    }
}
