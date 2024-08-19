using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PosInventorySystem
{
    class CategoriesData
    {
        public int CategoriesID { get; set; }
        public string Category{ get; set; }
        public string Date { get; set; }
        public List<CategoriesData> AllCategoriesData()
        {
            List<CategoriesData> listData = new List<CategoriesData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cabri\Documents\Funtilon.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM Category";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CategoriesData cdata = new CategoriesData();
                        cdata.CategoriesID = (int)reader["categoryid"];
                        cdata.Category = reader["category"].ToString();
                        cdata.Date = reader["date"].ToString();

                        listData.Add(cdata);
                    }
                }

            }
            return listData;
        }
    }
}
