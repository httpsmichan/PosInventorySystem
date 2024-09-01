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
    public partial class CashierMainForm : Form
    {
        public CashierMainForm()
        {
            InitializeComponent();
            displayUsername();
        }

        public void displayUsername()
        {
                string username = Form1.username.Substring(0, 1).ToUpper() + Form1.username.Substring(1);
                cashier.Text = ("@" + username);
           
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            adminAddProducts1.Visible = false;
            orders1.Visible = false;
            adminAddCategories1.Visible = false;
            cashierCustomerForm1.Visible = false;
            
            Dashboard adForm = dashboard1 as Dashboard;

            if (adForm != null)
            {
                adForm.refreshData();
            }

        }

        private void products_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            adminAddProducts1.Visible = true;
            orders1.Visible = false;
            adminAddCategories1.Visible = false;
            cashierCustomerForm1.Visible = false;

            AdminAddProducts prodForm = adminAddProducts1 as AdminAddProducts;

            if (prodForm != null)
            {
                prodForm.refreshData();
            }
        }

        private void orders_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            orders1.Visible = true;
            adminAddCategories1.Visible = false;
            cashierCustomerForm1.Visible = false;

            Orders orForm = orders1 as Orders;

            if (orForm != null)
            {
                orForm.refreshData();
            }
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            adminAddProducts1.Visible = false;
            adminAddCategories1.Visible =false;
            orders1.Visible = false;
            cashierCustomerForm1.Visible = true;

            CashierCustomerForm cusForm = cashierCustomerForm1 as CashierCustomerForm;

            if (cusForm != null)
            {
                cusForm.refreshData();
            }
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void categories_btn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            adminAddProducts1.Visible=false;
            adminAddCategories1.Visible = true;
            orders1.Visible = false;
            cashierCustomerForm1.Visible = false;

            AdminAddCategories catForm = adminAddCategories1 as AdminAddCategories;

            if (catForm != null)
            {
                catForm.refreshData();
            }
        }
    }
}
