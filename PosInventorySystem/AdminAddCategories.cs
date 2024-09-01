using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PosInventorySystem
{
    public partial class AdminAddCategories : UserControl
    {
        SqlConnection
           connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cabri\Documents\Funtilon.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminAddCategories()
        {
            InitializeComponent();

            displayCategoriesData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCategoriesData();
        }

        public void displayCategoriesData()
        {
            CategoriesData cData = new CategoriesData();
            List<CategoriesData> listData = cData.AllCategoriesData();

            category_grid.DataSource = listData;

            category_grid.Columns[0].Width = 205;
            category_grid.Columns[1].Width = 205;
            category_grid.Columns[2].Width = 205;

        }

        private void category_addbtn_Click(object sender, EventArgs e)
        {
            if (category_name.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();
                        string checkCat = "SELECT * FROM Category WHERE category = @cat";
                        using (SqlCommand cmd = new SqlCommand(checkCat, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", category_name.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);


                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Category: " + category_name.Text.Trim() + "already exist"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Category (category, date) VALUES(@cat, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@cat", category_name.Text.Trim());
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayCategoriesData();

                                    MessageBox.Show("Added Successfully! ", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void clearFields()
        {
            category_name.Text = "";
        }
        private void category_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        public int getID = 0;
        private void category_grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridViewRow row = category_grid.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                category_ID.Text = getID.ToString();
                category_name.Text = row.Cells[1].Value.ToString();
            }
        }

        private void category_updatebtn_Click(object sender, EventArgs e)
        {
            if (category_name.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update Cat ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "UPDATE Category SET category = @cat, date = @date WHERE CategoryID = @id";
                            using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
                            {
                                DateTime today = DateTime.Today;
                                updateCmd.Parameters.AddWithValue("@cat", category_name.Text.Trim());
                                updateCmd.Parameters.AddWithValue("@date", today);
                                updateCmd.Parameters.AddWithValue("@id", getID);

                                updateCmd.ExecuteNonQuery();
                                clearFields();
                                displayCategoriesData();

                                MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Update failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }

        private void category_removebtn_Click(object sender, EventArgs e)
        {
            if (category_name.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove Cat ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();
                            string removeData = "DELETE FROM Category WHERE  categoryid = @id";
                            using (SqlCommand deleteD = new SqlCommand(removeData, connect))
                            {
                                deleteD.Parameters.AddWithValue("@id", getID);

                                deleteD.ExecuteNonQuery();
                                clearFields();
                                displayCategoriesData();

                                MessageBox.Show("Removed Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Update failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


