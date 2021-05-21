using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using library;

namespace library
{
    public class CADProvincia
    {
        private string constring;

        public CADProvincia()
        {
            constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
        }

        public bool createProvincia(ENProvincia en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                return false;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Create provincia failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public bool readProvincia(ENProvincia en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Read provincia failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public bool updateProvincia(ENProvincia en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Update provincia failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public bool deleteProvincia(ENProvincia en)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Delete provincia failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

    }
}
