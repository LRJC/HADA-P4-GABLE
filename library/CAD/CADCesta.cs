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
            constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
        }

        public string getUserID(ENCesta c) 
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("" +
                    "select usuario " +
                    "from cesta " +
                    "where numCesta = " + c.NumCesta +
                    "", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable linCestData = new DataTable();
                        sda.Fill(linCestData);

                        if (linCestData.Rows.Count > 0)
                            return linCestData.Rows[0][0].ToString();
                        return null;
                    }
                }
            }
        }

        public bool proceedToBuy(ENCesta c) { return false; }

    }
}
