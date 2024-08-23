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
            displayTotalPrice();
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

            dataGridView1.DataSource = listData;



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
            displayTotalPrice();
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

                        if (temp == 0)
                        {
                            idGen = 1;
                        }
                        else
                        {
                            idGen = temp + 1;
                        }
                    }
                    else
                    {
                        idGen = 1;
                    }
                }
            }
        }

        private float totalPrice = 0;
        public void displayTotalPrice()
        {
            IDGenerator();

            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM (Subtotal) FROM Purchase WHERE CustomerID = @catID";

                    using (SqlCommand cmd = new SqlCommand(@selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("catID", idGen);

                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);

                            order_Totalprice.Text = totalPrice.ToString("0.00");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void order_Gridview1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int prodID = 0;
        private void order_Gridview1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void order_removebtn_Click(object sender, EventArgs e)
        {
            if (prodID == 0)
            {
                MessageBox.Show("Select an item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to remove ID: " + prodID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM Purchase WHERE PurchaseID = @pID";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@pID", prodID);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Removed Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            displayOrders();
            displayTotalPrice();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                prodID = (int)row.Cells[0].Value;

            }
        }

        public void clearFields()
        {
            order_Cat.SelectedIndex = -1;
            order_prodID.SelectedIndex = -1;
            order_prodName.Text = "";
            order_Totalprice.Text = "";
            order_qty.Value = 0;
        }
        private void order_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void order_PayOrder_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (order_Cashamount.Text == "" || dataGridView1.Rows.Count < 0)
            {
                MessageBox.Show("Something went wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure to pay your orders? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string insertData = "INSERT INTO Billing (CustomerID, ProductID, TotalPrice, Amount, Change, OrderDate)" +
                                "VALUES (@cID, @pID, @totalP, @amount, @change, @odate)";

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@cID", idGen);
                                cmd.Parameters.AddWithValue("@pID", order_prodID.Text);
                                cmd.Parameters.AddWithValue("@totalP", order_Totalprice.Text);
                                cmd.Parameters.AddWithValue("@amount", order_Cashamount.Text);
                                cmd.Parameters.AddWithValue("@change", order_Change.Text);

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@odate", today);

                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Paid Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            displayTotalPrice();

        }

        private void order_Cashamount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(order_Cashamount.Text);
                    float getChange = (getAmount - totalPrice);

                    if (getChange <= -1)
                    {
                        order_Cashamount.Text = "";
                        order_Change.Text = "";
                    }
                    else
                    {
                        order_Change.Text = getChange.ToString("0.00");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    order_Cashamount.Text = "";
                    order_Change.Text = "";
                }
            }
        }
    }
}
