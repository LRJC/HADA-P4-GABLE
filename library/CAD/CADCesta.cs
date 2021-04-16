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

namespace library
{
    class CADCesta
    {
        private string constring;

        public CADCesta()
        {
            constring = ConfigurationManager.ConnectionStrings["conexion"].ToString();
        }

        public bool addProduct(ENCesta c, Producto p) {}

        public bool removeProduct(ENCesta c, Producto p) {}

        public bool addUnit(ENCesta c, Producto p) {}

        public bool removeUnit(ENCesta c, Producto p) {}

        public bool proceedToBuy(ENCesta c) {}

    }
}
