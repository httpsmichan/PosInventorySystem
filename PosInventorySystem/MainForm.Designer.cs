namespace PosInventorySystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.aboutus_btn = new System.Windows.Forms.Button();
            this.inventory_btn = new System.Windows.Forms.Button();
            this.customer_btn = new System.Windows.Forms.Button();
            this.staff_btn = new System.Windows.Forms.Button();
            this.products_btn = new System.Windows.Forms.Button();
            this.categories_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboard1 = new PosInventorySystem.Dashboard();
            this.adminAddCategories1 = new PosInventorySystem.AdminAddCategories();
            this.adminAddProducts1 = new PosInventorySystem.AdminAddProducts();
            this.adminAddUsers1 = new PosInventorySystem.AdminAddUsers();
            this.cashierCustomerForm1 = new PosInventorySystem.CashierCustomerForm();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.aboutus_btn);
            this.panel1.Controls.Add(this.inventory_btn);
            this.panel1.Controls.Add(this.customer_btn);
            this.panel1.Controls.Add(this.staff_btn);
            this.panel1.Controls.Add(this.products_btn);
            this.panel1.Controls.Add(this.categories_btn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Controls.Add(this.admin);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 767);
            this.panel1.TabIndex = 0;
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.Color.Black;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logout_btn.Location = new System.Drawing.Point(42, 700);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(130, 29);
            this.logout_btn.TabIndex = 10;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.button9_Click);
            // 
            // aboutus_btn
            // 
            this.aboutus_btn.FlatAppearance.BorderSize = 0;
            this.aboutus_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.aboutus_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.aboutus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutus_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutus_btn.Location = new System.Drawing.Point(0, 504);
            this.aboutus_btn.Name = "aboutus_btn";
            this.aboutus_btn.Size = new System.Drawing.Size(221, 53);
            this.aboutus_btn.TabIndex = 9;
            this.aboutus_btn.Text = "      About Us";
            this.aboutus_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutus_btn.UseVisualStyleBackColor = true;
            // 
            // inventory_btn
            // 
            this.inventory_btn.FlatAppearance.BorderSize = 0;
            this.inventory_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.inventory_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.inventory_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.inventory_btn.Location = new System.Drawing.Point(0, 457);
            this.inventory_btn.Name = "inventory_btn";
            this.inventory_btn.Size = new System.Drawing.Size(221, 53);
            this.inventory_btn.TabIndex = 8;
            this.inventory_btn.Text = "       Inventory";
            this.inventory_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventory_btn.UseVisualStyleBackColor = true;
            // 
            // customer_btn
            // 
            this.customer_btn.FlatAppearance.BorderSize = 0;
            this.customer_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.customer_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customer_btn.Location = new System.Drawing.Point(0, 407);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(221, 53);
            this.customer_btn.TabIndex = 7;
            this.customer_btn.Text = "       Customer\'s Info";
            this.customer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customer_btn.UseVisualStyleBackColor = true;
            this.customer_btn.Click += new System.EventHandler(this.customer_btn_Click);
            // 
            // staff_btn
            // 
            this.staff_btn.FlatAppearance.BorderSize = 0;
            this.staff_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.staff_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.staff_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staff_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staff_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.staff_btn.Location = new System.Drawing.Point(0, 358);
            this.staff_btn.Name = "staff_btn";
            this.staff_btn.Size = new System.Drawing.Size(221, 53);
            this.staff_btn.TabIndex = 6;
            this.staff_btn.Text = "       Staff\'s Info";
            this.staff_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staff_btn.UseVisualStyleBackColor = true;
            this.staff_btn.Click += new System.EventHandler(this.staff_btn_Click);
            // 
            // products_btn
            // 
            this.products_btn.FlatAppearance.BorderSize = 0;
            this.products_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.products_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.products_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.products_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.products_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.products_btn.Location = new System.Drawing.Point(0, 308);
            this.products_btn.Name = "products_btn";
            this.products_btn.Size = new System.Drawing.Size(221, 53);
            this.products_btn.TabIndex = 4;
            this.products_btn.Text = "       Products";
            this.products_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.products_btn.UseVisualStyleBackColor = true;
            this.products_btn.Click += new System.EventHandler(this.products_btn_Click);
            // 
            // categories_btn
            // 
            this.categories_btn.FlatAppearance.BorderSize = 0;
            this.categories_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.categories_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.categories_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categories_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categories_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.categories_btn.Location = new System.Drawing.Point(0, 260);
            this.categories_btn.Name = "categories_btn";
            this.categories_btn.Size = new System.Drawing.Size(221, 53);
            this.categories_btn.TabIndex = 3;
            this.categories_btn.Text = "       Categories";
            this.categories_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categories_btn.UseVisualStyleBackColor = true;
            this.categories_btn.Click += new System.EventHandler(this.categories_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dashboard_btn.Location = new System.Drawing.Point(0, 212);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(221, 53);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "       Dashboard";
            this.dashboard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.Cornsilk;
            this.admin.Location = new System.Drawing.Point(80, 134);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(54, 15);
            this.admin.TabIndex = 1;
            this.admin.Text = "@Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PosInventorySystem.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(65, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cashierCustomerForm1);
            this.panel2.Controls.Add(this.adminAddUsers1);
            this.panel2.Controls.Add(this.adminAddProducts1);
            this.panel2.Controls.Add(this.adminAddCategories1);
            this.panel2.Controls.Add(this.dashboard1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(221, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 767);
            this.panel2.TabIndex = 1;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1076, 767);
            this.dashboard1.TabIndex = 0;
            // 
            // adminAddCategories1
            // 
            this.adminAddCategories1.Location = new System.Drawing.Point(0, 0);
            this.adminAddCategories1.Name = "adminAddCategories1";
            this.adminAddCategories1.Size = new System.Drawing.Size(1076, 767);
            this.adminAddCategories1.TabIndex = 1;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1076, 767);
            this.adminAddProducts1.TabIndex = 2;
            // 
            // adminAddUsers1
            // 
            this.adminAddUsers1.Location = new System.Drawing.Point(0, 0);
            this.adminAddUsers1.Name = "adminAddUsers1";
            this.adminAddUsers1.Size = new System.Drawing.Size(1076, 767);
            this.adminAddUsers1.TabIndex = 3;
            // 
            // cashierCustomerForm1
            // 
            this.cashierCustomerForm1.Location = new System.Drawing.Point(0, 0);
            this.cashierCustomerForm1.Name = "cashierCustomerForm1";
            this.cashierCustomerForm1.Size = new System.Drawing.Size(1076, 767);
            this.cashierCustomerForm1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 767);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point-of-Sale (POS) with Inventory and Supply Management for Funtilon Hardware an" +
    "d Construction Supplies";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label admin;
        private System.Windows.Forms.Button customer_btn;
        private System.Windows.Forms.Button staff_btn;
        private System.Windows.Forms.Button products_btn;
        private System.Windows.Forms.Button categories_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button aboutus_btn;
        private System.Windows.Forms.Button inventory_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel panel2;
        private CashierCustomerForm cashierCustomerForm1;
        private AdminAddUsers adminAddUsers1;
        private AdminAddProducts adminAddProducts1;
        private AdminAddCategories adminAddCategories1;
        private Dashboard dashboard1;
    }
}