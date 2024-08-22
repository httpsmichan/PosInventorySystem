using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PosInventorySystem
{
    public partial class Orders : UserControl
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cabri\Documents\Funtilon.mdf;Integrated Security=True;Connect Timeout=30");
        public Orders()
        {
            InitializeComponent();
            displayAllAvailableProducts();
            displayAllCategories();
            displayOrders();
        }

        public void displayAllAvailableProducts()
        {
            ProductData apData = new ProductData();
            List<ProductData> listData = apData.allAvailableProducts();

            order_Gridview1.DataSource = listData;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adduser_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayAllCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM Category";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            order_Cat.Items.Clear();

                            while (reader.Read())
                            {
                                string item = reader.GetString(1);
                                order_Cat.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayOrders()
        {
            OrdersData oData = new OrdersData();
            List<OrdersData> listData = oData.allOrdersData();

            order_Gridview2.DataSource = listData;

        }

        private void order_Cat_SelectedIndexChanged(object sender, EventArgs e)
        {
            order_prodID.SelectedIndex = -1;
            order_prodID.Items.Clear();
            order_prodName.Text = "";
            order_price.Text = "";
            order_qty.Value = 0;

            string selectedValue = order_Cat.SelectedItem as string;

            if (selectedValue != null)
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string selectData = $"SELECT * FROM Product WHERE Category = '{selectedValue}' AND Status = @status ";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["ProductID"].ToString();
                                    order_prodID.Items.Add(value);
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void order_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = order_prodID.SelectedItem as string;

            if (checkConnection())
            {
                if (selectedValue != null)
                {
                    try
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM Product WHERE ProductID = '{selectedValue}' AND Status = @status ";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["ProductName"].ToString();
                                    float prodPrice = Convert.ToSingle(reader["Price"]);

                                    order_prodName.Text = prodName;
                                    order_price.Text = prodPrice.ToString("0.00");

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void category_addbtn_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (order_Cat.SelectedIndex == -1 || order_prodID.SelectedIndex == -1 || order_prodName.Text == "" ||
                order_price.Text == "" || order_qty.Value == 0)
            {
                MessageBox.Show("Select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        float getPrice = 0;
                        string selectOrder = "SELECT * FROM Product WHERE ProductID = @prodID";

                        using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                        {
                            getOrder.Parameters.AddWithValue("@prodID", order_prodID.SelectedItem);

                            using (SqlDataReader reader = getOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object rawValue = reader["Price"];

                                    if (rawValue != DBNull.Value)
                                    {
                                        getPrice = Convert.ToSingle(rawValue);
                                    }
                                }
                            }
                        }

                        string insertData = "INSERT INTO Purchase (CustomerID, ProductID, ProductName, Category, Quantity, OriginalPrice, Subtotal, OrderDate)" +
                             "VALUES (@catID, @prodID, @prodName, @cat, @qty, @oPrice, @subT, @oDate)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@catID", idGen);
                            cmd.Parameters.AddWithValue("@prodID", order_prodID.SelectedItem);
                            cmd.Parameters.AddWithValue("@prodName", order_prodName.Text.Trim());
                            cmd.Parameters.AddWithValue("@cat", order_Cat.SelectedItem);
                            cmd.Parameters.AddWithValue("@qty", order_qty.Value);
                            cmd.Parameters.AddWithValue("@oPrice", getPrice);


                            float totalP = (getPrice * (int)order_qty.Value);

                            cmd.Parameters.AddWithValue("@subT", totalP);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@oDate", today);

                            cmd.ExecuteNonQuery();

                            displayOrders();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            displayOrders();
        }

        private int idGen;

        public void IDGenerator()
        {

            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cabri\Documents\Funtilon.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();

                string selectData = "SELECT MAX(CustomerID) FROM Billing";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);
                        idGen = temp + 1;
                    }
                    else
                    {
                        idGen = 1;
                    }
                }
            }
        }
    }
}
