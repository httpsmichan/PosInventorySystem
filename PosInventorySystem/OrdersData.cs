using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace PosInventorySystem
{

    class OrdersData
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cabri\Documents\Funtilon.mdf;Integrated Security=True;Connect Timeout=30");

        public int PurchaseID { set; get; }
        public string CustomerID { set; get; }
        public string ProductID { set; get; }
        public string ProductName { set; get; }
        public string Category { set; get; }
        public string OriginalPrice { set; get; }
        public string Quantity { set; get; }
        public string Subtotal { set; get; }
        public string OrderDate { set; get; }

        public List<OrdersData> allOrdersData()
        {
            List<OrdersData> listData = new List<OrdersData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    int custID = 0;
                    string selectCustData = "SELECT MAX (CustomerID) FROM Purchase";

                    using (SqlCommand cmd = new SqlCommand(selectCustData, connect))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);

                            if (temp == 0)
                            {
                                custID = 1;
                            }
                            else
                            {
                                custID = temp;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error ID");
                        }
                    }

                    string selectData = "SELECT * FROM Purchase WHERE CustomerID = @catID ";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                       cmd.Parameters.AddWithValue("@catID", custID);

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            OrdersData oData = new OrdersData();
                            oData.PurchaseID = (int)reader["PurchaseID"];
                            oData.CustomerID = reader["CustomerID"].ToString();
                            oData.ProductID = reader["ProductID"].ToString();
                            oData.ProductName = reader["ProductName"].ToString();
                            oData.Category = reader["Category"].ToString();
                            oData.OriginalPrice = reader["OriginalPrice"].ToString();
                            oData.Quantity = reader["Quantity"].ToString();
                            oData.Subtotal = reader["Subtotal"].ToString();
                            oData.OrderDate = reader["OrderDate"].ToString();

                            listData.Add(oData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed: " + ex);
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
