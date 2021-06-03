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

        public bool AddNewBasketForUser(string dni)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("" +
                    "select *" +
                    "from cesta " +
                    "where usuario = " + dni +
                    "", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable cestData = new DataTable();
                        sda.Fill(cestData);

                        if (cestData.Rows.Count > 0)
                            return false;

                        int maxIndex = -1;

                        foreach (DataRow row in cestData.Rows)
                        {
                            int linIndex = int.Parse(row[1].ToString());
                            if (linIndex > maxIndex)
                                maxIndex = linIndex;
                        }

                        SqlCommand rowCmd = new SqlCommand("" +
                            "insert into cesta (numCesta, usuario) values (" +
                            (maxIndex + 1).ToString() + "," + dni, con);

                        rowCmd.ExecuteNonQuery();

                        return true;
                    }
                }
            }
        }

        public int getBasketByDNI(string dni)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("" +
                    "select * " +
                    "from cesta " +
                    "where usuario = " + dni +
                    "", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable cestData = new DataTable();
                        sda.Fill(cestData);

                        if (cestData.Rows.Count > 0)
                            return int.Parse(cestData.Rows[0][0].ToString());
                        return -1;
                    }
                }
            }
        }

        public string getDNIByBasket(int basket)
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("" +
                    "select * " +
                    "from cesta " +
                    "where numCesta = " + basket.ToString() +
                    "", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable cestData = new DataTable();
                        sda.Fill(cestData);

                        if (cestData.Rows.Count > 0)
                            return cestData.Rows[0][1].ToString();
                        return null;
                    }
                }
            }
        }

        public bool ProceedToBuy(ENCesta c) { return false; }
        
        public DataTable ShowBasketItems(string dni) {
            //string constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("" +
                    "select p.nombre, p.imagen, lc.numCesta, lc.linea, " +
                    "lc.importe, lc.cantidad, lc.importe*lc.cantidad as total " +
                    "from linCest lc " +
                    "inner join producto p " +
                    "on lc.producto = p.id_producto " +
                    "inner join cesta c " +
                    "on c.numCesta = lc.numCesta and c.usuario = '" + dni + "'", con))
                // TO DO: Detect user session in c.usuario
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable linCestData = new DataTable();
                        sda.Fill(linCestData);
                        return linCestData;
                    }
                }
            }
        }

        public void InsertItemsIntoBasket(int numCesta, int producto, float importe, int cantidad)
        {
            //string constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("" +
                    "select *" +
                    "from linCest " +
                    "where numCesta = " + numCesta +
                    "", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable linCestData = new DataTable();
                        sda.Fill(linCestData);
                        int maxIndex = -1;

                        foreach (DataRow row in linCestData.Rows)
                        {
                            int linIndex = int.Parse(row[1].ToString());
                            if (linIndex > maxIndex)
                                maxIndex = linIndex;
                        }

                        SqlCommand rowCmd = new SqlCommand("" +
                            "insert into linCest values (" +
                            numCesta.ToString() + "," + (maxIndex + 1).ToString() + "," + producto.ToString() +
                            "," + importe.ToString() + "," + cantidad.ToString(), con);

                        rowCmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void InsertItemsIntoOrders(int numCesta)
        {
            //string constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("" +
                    "select *" +
                    "from linCest " +
                    "where numCesta = " + numCesta +
                    "", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable linCestData = new DataTable();
                        sda.Fill(linCestData);

                        foreach (DataRow row in linCestData.Rows)
                        {
                            SqlCommand rowCmd = new SqlCommand("" +
                                "insert into linPed values (" +
                                row[0] + "," + row[1] + "," + row[2] +
                                "," + row[3] + "," + row[4], con);

                            rowCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public void DeleteItemsFromBasket(int numCesta)
        {
            //string constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("" +
                    "select *" +
                    "from linCest " +
                    "where numCesta = " + numCesta +
                    "", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable linCestData = new DataTable();
                        sda.Fill(linCestData);

                        foreach (DataRow row in linCestData.Rows)
                        {
                            SqlCommand rowCmd = new SqlCommand("" +
                                "delete from linCest " +
                                "where numCesta = " + numCesta + " " +
                                "and linea = " + row[1], con);

                            rowCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public bool CheckIfSomeItem()
        {
            //string constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("" +
                    "select * " +
                    "from linCest " +
                    "", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable linCestData = new DataTable();
                        sda.Fill(linCestData);

                        return linCestData.Rows.Count > 0;
                    }
                }
            }
        }

        public bool CheckIfItemExists(int numCesta, int linea)
        {
            //string constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("" +
                    "select * " +
                    "from linCest " +
                    "where numCesta = " + numCesta + " and linea = " + linea +
                    "", con))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable linCestData = new DataTable();
                        sda.Fill(linCestData);

                        return linCestData.Rows.Count > 0;
                    }
                }
            }
        }

        public bool CheckIfHaveBuyData(string userID, int numCesta)
        {
            if (userID != null)
            {
                //string constring = ConfigurationManager.ConnectionStrings["bbdd"].ToString();
                using (SqlConnection con = new SqlConnection(constring))
                {
                    using (SqlCommand cmd = new SqlCommand("" +
                        "select u.tarjeta, de.provincia, de.pueblo, de.calle" +
                        "from usuario u, dirEnvio de " +
                        "where u.dni = de.usuario" +
                        "", con))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable userData = new DataTable();
                            sda.Fill(userData);

                            if (userData.Rows.Count > 0)
                            {
                                bool haveAllDependencies = true;

                                for (int i = 0; i < userData.Columns.Count; i++)
                                {
                                    if (userData.Rows[0][i] == DBNull.Value)
                                        haveAllDependencies = false;
                                }

                                return haveAllDependencies;
                            }
                        }
                    }
                }
            }

            return false;
        }

    }
}
