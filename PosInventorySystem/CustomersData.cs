using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace PosInventorySystem
{
    class CustomersData
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cabri\Documents\Funtilon.mdf;Integrated Security=True;Connect Timeout=30");

        public string CustomerID { get; set; }
        public string TotalPrice { get; set; }
        public string Amount { get; set; }
        public string Change { get; set; }
        public string Date { get; set; }

        public List<CustomersData> allCustomers()
        {
            List<CustomersData> listData = new List<CustomersData>();

            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM Billing";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CustomersData cdata = new CustomersData();

                            cdata.CustomerID = reader["CustomerID"].ToString();
                            cdata.TotalPrice = reader["TotalPrice"].ToString();
                            cdata.Amount = reader["Amount"].ToString();
                            cdata.Change = reader["Change"].ToString();
                            cdata.Date = reader["OrderDate"].ToString();

                            listData.Add(cdata);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Failed Connection: " + ex); 
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;

        }

        public List<CustomersData> allTodayCustomers()
        {
            List<CustomersData> listData = new List<CustomersData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    DateTime today = DateTime.Today;

                    string selectData = "SELECT * FROM Billing WHERE OrderDate = @date";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@date", today);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            CustomersData cdata = new CustomersData();
                            cdata.CustomerID = reader["CustomerID"].ToString();
                            cdata.TotalPrice = reader["TotalPrice"].ToString();
                            cdata.Amount = reader["Amount"].ToString();
                            cdata.Change = reader["Change"].ToString();
                            cdata.Date = reader["OrderDate"].ToString();

                            listData.Add(cdata);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed Connection: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;

        }

    }
}
