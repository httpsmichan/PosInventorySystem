using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosInventorySystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            displayUsername();
        }

        public void displayUsername()
        {
           
                string username = Form1.username.Substring(0, 1).ToUpper() + Form1.username.Substring(1);
                admin.Text = ("@" + username);
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }

            
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddUsers1.Visible = false;
            cashierCustomerForm1.Visible = false;

            Dashboard adForm = dashboard1 as Dashboard;

            if (adForm != null)
            {
                adForm.refreshData();
            }

        }

        private void categories_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            adminAddCategories1.Visible = true;
            adminAddProducts1.Visible = false;
            adminAddUsers1.Visible = false;
            cashierCustomerForm1.Visible = false;

            AdminAddCategories catForm = adminAddCategories1 as AdminAddCategories;

            if (catForm != null)
            {
                catForm.refreshData();
            }
        }

        private void products_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = true;
            adminAddUsers1.Visible = false;
            cashierCustomerForm1.Visible = false;

            AdminAddProducts prodForm = adminAddProducts1 as AdminAddProducts;

            if (prodForm != null)
            {
                prodForm.refreshData();
            }
        }

        private void staff_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddUsers1.Visible = true;
            cashierCustomerForm1.Visible = false;

            AdminAddUsers stForm = adminAddUsers1 as AdminAddUsers;

            if (stForm != null)
            {
                stForm.refreshData();
            }
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            adminAddCategories1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddUsers1.Visible = false;
            cashierCustomerForm1.Visible = true;

            CashierCustomerForm cusForm = cashierCustomerForm1 as CashierCustomerForm;

            if (cusForm != null)
            {
                cusForm.refreshData();
            }
        }
    }
}
