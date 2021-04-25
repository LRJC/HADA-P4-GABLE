using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using library.EN;

namespace library.CAD
{
    class CADCesta
    {
        private string constring;

        public CADCesta()
        {
            constring = ConfigurationManager.ConnectionStrings["conexion"].ToString();
        }

        /*public bool addProduct(ENCesta c, Producto p) { return false; }

        public bool removeProduct(ENCesta c, Producto p) { return false; }

        public bool addUnit(ENCesta c, Producto p) { return false; }

        public bool removeUnit(ENCesta c, Producto p) { return false; }

        public bool proceedToBuy(ENCesta c) { return false; }*/

    }
}
