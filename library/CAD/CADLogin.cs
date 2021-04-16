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
    class CADLogin
    {
        private string constring;

        public CADLogin()
        {
            constring = ConfigurationManager.ConnectionStrings["conexion"].ToString();
        }

        public bool tryLogin(ENLogin en)
        {
            /*
            TODO:
                1. Check if user is in the database
                if true
                    check if password match
                    if match
                        proceed to login
                    else
                        throw password error
                else
                    throw user error
            */
        }

    }
}
