﻿using System;
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
                SqlCommand com1 = new SqlCommand("select * from localidad where nif = '" + loc.codm + "' AND provincia = '" + loc.provincia + "';", c);
                SqlDataReader dr = com1.ExecuteReader();

                if (dr.Read()) return false;//comprobamos qeu no exista
                dr.Close();

                SqlCommand com2 = new SqlCommand("Insert into localidad(codm,pueblo,provincia) VALUES ('" + loc.codm + "','" + loc.pueblo + "','" + loc.provincia + "')", c);
                com2.ExecuteNonQuery();

                return true;
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
                Console.WriteLine($"Read localidad failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public bool readFirstLocalidad(ENLocalidad loc)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Read first localidad failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }

        public bool readNextLocalidad(ENLocalidad loc)
        {
            SqlConnection c = new SqlConnection(constring);
            try
            {
                c.Open();
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Read next localidad failed. Error: {0}", ex.Message);
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
                if (!loc.pueblo.Length() > 0) {//comprobamos que no esté vacío el campo
                    SqlCommand com1 = new SqlCommand("update localidad set pueblo = '" + loc.pueblo + "' where nif = '" + loc.codm + "' AND provincia = '" + loc.provincia + "';", c);
                    if (com1.ExecuteNonQuery() == 0) return false;
                }
                if(loc.provincia.Length() > 0)
                {
                    SqlCommand com2 = new SqlCommand("update localidad set provincia = '" + loc.provincia + "' where nif = '" + loc.codm + "' AND provincia = '" + loc.provincia + "';", c);
                    if (com2.ExecuteNonQuery() == 0) return false;
                }
                

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Update localidad failed. Error: {0}", ex.Message);
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
                SqlCommand com = new SqlCommand("delete from localidad where nif = '" + loc.codm + "' AND provincia = '" + loc.provincia + "';", c);

                if (com.ExecuteNonQuery() == 0) return false;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Delete localidad failed. Error: {0}", ex.Message);
                return false;
            }
            finally
            {
                c.Close();
            }
        }
        
    }
}
