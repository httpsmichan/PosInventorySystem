using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PosInventorySystem
{
    class ProductData
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }


        public List<ProductData> AllProductsData()
        {
            List<ProductData> listData = new List<ProductData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cabri\Documents\Funtilon.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM Product";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ProductData proddata = new ProductData();
                        proddata.ProductID = (int)reader["ProductID"];
                        proddata.ProductName = reader["ProductName"].ToString();
                        proddata.Category = reader["Category"].ToString();
                        proddata.Price = reader["Price"].ToString();
                        proddata.Status = reader["Status"].ToString();
                        proddata.Date = reader["Date"].ToString();


                        listData.Add(proddata);
                    }
                }

            }
            return listData;
        }
    }
}
