using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PosInventorySystem
{
    class UsersData
    {
        public int StaffID {  get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Mobilenum { get; set; }


        public List<UsersData> AllUsersData()
        {
            List<UsersData> listData = new List<UsersData>();

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cabri\Documents\Funtilon.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string selectData = "SELECT * FROM Staff";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        UsersData udata = new UsersData();
                        udata.StaffID = (int)reader["staffid"];
                        udata.Username = reader["username"].ToString();
                        udata.Password = reader["password"].ToString();
                        udata.Email = reader["email"].ToString();
                        udata.Role = reader["role"].ToString();
                        udata.Mobilenum = reader["mobilenum"].ToString();
              

                        listData.Add(udata);
                    }
                }

            }
            return listData;
        }
    }
}
