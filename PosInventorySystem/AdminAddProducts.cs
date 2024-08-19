using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PosInventorySystem
{
    public partial class AdminAddProducts : UserControl
    {
        SqlConnection
          connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cabri\Documents\Funtilon.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminAddProducts()
        {
            InitializeComponent();
            displayCategories();
            displayAllProducts();
        }

        public bool emptyFields()
        {
            if (addprod_ID.Text == "" || addprod_name.Text == "" || addprod_category.SelectedIndex == -1
                || addprod_price.Text == "" || addprod_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayCategories()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM Category";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                addprod_category.Items.Add(reader["category"].ToString());
                            }
                        }


                    }
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connect.Close();
                }
            }
        }
        private void addprod_addbtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM Product WHERE ProductID = @prodID";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@prodID", addprod_ID.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Product ID: " + addprod_ID.Text.Trim() + " already exists"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Product (productname, category, price, status, date)" +
                                    "VALUES (@prodName, @cat, @price, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {

                                    insertD.Parameters.AddWithValue("@prodName", addprod_name.Text.Trim());
                                    insertD.Parameters.AddWithValue("@cat", addprod_category.SelectedItem);
                                    insertD.Parameters.AddWithValue("@price", addprod_ID.Text.Trim());
                                    insertD.Parameters.AddWithValue("@status", addprod_status.SelectedItem);

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayAllProducts();


                                    MessageBox.Show("Added Successfully! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed connection :" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        public bool checkConnection()
        {
            if (connect.State != ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void displayAllProducts()
        {
            ProductData apData = new ProductData();
            List<ProductData> listData = apData.AllProductsData();

            addprod_dataGrid.DataSource = listData;

            addprod_dataGrid.Columns[0].Width = 78;
            addprod_dataGrid.Columns[1].Width = 200;
            addprod_dataGrid.Columns[2].Width = 200;
            addprod_dataGrid.Columns[3].Width = 100;
            addprod_dataGrid.Columns[4].Width = 200;
            addprod_dataGrid.Columns[5].Width = 200;
        }

        public void clearFields()
        {
            addprod_ID.Text = "";
            addprod_name.Text = "";
            addprod_category.SelectedIndex = -1;
            addprod_price.Text = "";
            addprod_status.SelectedIndex = -1;
            addprod_date.Text = "";
        }
        private void addprod_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;
        private void addprod_dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = addprod_dataGrid.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                addprod_ID.Text = row.Cells[0].Value.ToString();
                addprod_name.Text = row.Cells[1].Value.ToString();
                addprod_category.Text = row.Cells[2].Value.ToString();
                addprod_price.Text = row.Cells[3].Value.ToString();
                addprod_status.Text = row.Cells[4].Value.ToString();
                addprod_date.Text = row.Cells[5].Value.ToString();

                addprod_ID.Text = getID.ToString();
            }
        }

        private void addprod_updatebtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update Product ID: " +
                    addprod_ID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE Product SET ProductName = @prodname, Category = @cat, " +
                                "Price = @price, Status = @status, Date = @date WHERE ProductID = @prodID";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@prodID", addprod_ID.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodName", addprod_name.Text.Trim());
                                updateD.Parameters.AddWithValue("@cat", addprod_category.SelectedItem);
                                updateD.Parameters.AddWithValue("@price", addprod_price.Text.Trim());
                                updateD.Parameters.AddWithValue("@status", addprod_status.SelectedItem);

                                DateTime today = DateTime.Today;
                                updateD.Parameters.AddWithValue("@date", today);

                                updateD.ExecuteNonQuery();
                                clearFields();
                                displayAllProducts();

                                MessageBox.Show("Updated Successfully! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed connection :" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }

        private void addprod_removebtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete Product ID: " +
                    addprod_ID.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM Product WHERE  productid = @prodID";

                            using (SqlCommand deleteD = new SqlCommand(deleteData, connect))
                            {
                                deleteD.Parameters.AddWithValue("@prodID",getID);
                   
                                deleteD.ExecuteNonQuery();
                                clearFields();
                                displayAllProducts();

                                MessageBox.Show("Removed Successfully! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed connection :" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }
    }
}


