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
    public class CADLocalidad
    {
        private string constring;

        public CADLocalidad()
        {
            constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
        }

        public bool createLocalidad(ENLocalidad loc)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Create localidad failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }
        
        public bool readLocalidad(ENLocalidad loc)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Create localidad failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public bool updateLocalidad(ENLocalidad loc)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Create localidad failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public bool deleteLocalidad(ENLocalidad loc)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Create localidad failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }
        
    }
}
