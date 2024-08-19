using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PosInventorySystem
{
    public partial class AdminAddUsers : UserControl
    {

        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cabri\Documents\Funtilon.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminAddUsers()
        {
            InitializeComponent();
            displayAllUsersData();
        }

        public void displayAllUsersData()
        {
            UsersData udata = new UsersData();

            List<UsersData> listData = udata.AllUsersData();

            adduser_dataGrid.DataSource = listData;

            adduser_dataGrid.Columns[0].Width = 78;
            adduser_dataGrid.Columns[1].Width = 200;
            adduser_dataGrid.Columns[2].Width = 200;
            adduser_dataGrid.Columns[3].Width = 200;
            adduser_dataGrid.Columns[4].Width = 100;
            adduser_dataGrid.Columns[5].Width = 200;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adduser_uname.Text == "" || adduser_pass.Text == "")
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
                        string checkUsername = "SELECT * FROM Staff WHERE username = @usern";

                        using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", adduser_uname.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(adduser_role.Text.Trim() + "", "is already taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO Staff (username, password, role, email, mobilenum)" + "VALUES(@usern, @pass, @role, @email, @mnum)";

                                using (SqlCommand insertID = new SqlCommand(insertData, connect))
                                {
                                    insertID.Parameters.AddWithValue("@usern", adduser_uname.Text.Trim());
                                    insertID.Parameters.AddWithValue("@pass", adduser_pass.Text.Trim());
                                    insertID.Parameters.AddWithValue("@role", adduser_role.SelectedItem.ToString());
                                    insertID.Parameters.AddWithValue("@email", adduser_email.Text.Trim());
                                    insertID.Parameters.AddWithValue("@mnum", adduser_mnum.Text.Trim());


                                    insertID.ExecuteNonQuery();
                                    clearFields();
                                    displayAllUsersData();


                                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (adduser_uname.Text == "" || adduser_pass.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update User ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "UPDATE Staff SET username = @usern, password = @pass, role = @role, email = @email, mobilenum = @mnum WHERE staffid = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@usern", adduser_uname.Text.Trim());
                                updateD.Parameters.AddWithValue("@pass", adduser_pass.Text.Trim());
                                updateD.Parameters.AddWithValue("@role", adduser_role.SelectedItem.ToString());
                                updateD.Parameters.AddWithValue("@email", adduser_email.Text.Trim());
                                updateD.Parameters.AddWithValue("@mnum", adduser_mnum.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                clearFields();
                                displayAllUsersData();

                                MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
        }



        public void clearFields()
        {
            adduser_ID.Text = "";
            adduser_uname.Text = "";
            adduser_pass.Text = "";
            adduser_role.SelectedIndex = -1;
            adduser_email.Text = "";
            adduser_mnum.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (adduser_uname.Text == "" || adduser_pass.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove User ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "DELETE FROM Staff WHERE staffid = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                clearFields();
                                displayAllUsersData();

                                MessageBox.Show("User Removed Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
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

        private int getID = 0;

        private void adduser_dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = adduser_dataGrid.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                string username = row.Cells[1].Value.ToString();
                string password = row.Cells[2].Value.ToString();
                string role = row.Cells[4].Value.ToString();
                string email = row.Cells[3].Value.ToString();
                string mnum = row.Cells[5].Value.ToString();

                adduser_ID.Text = getID.ToString();
                adduser_uname.Text = username;
                adduser_pass.Text = password;
                adduser_role.Text = role;
                adduser_email.Text = email;
                adduser_mnum.Text = mnum;

            }
        }

        private void adduser_dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
