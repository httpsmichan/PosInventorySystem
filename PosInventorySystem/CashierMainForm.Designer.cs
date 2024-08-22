namespace PosInventorySystem
{
    partial class CashierMainForm
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
            this.customer_btn = new System.Windows.Forms.Button();
            this.orders_btn = new System.Windows.Forms.Button();
            this.products_btn = new System.Windows.Forms.Button();
            this.categories_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.cashier = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboard1 = new PosInventorySystem.Dashboard();
            this.adminAddProducts1 = new PosInventorySystem.AdminAddProducts();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.orders1 = new PosInventorySystem.Orders();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.aboutus_btn);
            this.panel1.Controls.Add(this.customer_btn);
            this.panel1.Controls.Add(this.orders_btn);
            this.panel1.Controls.Add(this.products_btn);
            this.panel1.Controls.Add(this.categories_btn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Controls.Add(this.cashier);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 767);
            this.panel1.TabIndex = 1;
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
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // aboutus_btn
            // 
            this.aboutus_btn.FlatAppearance.BorderSize = 0;
            this.aboutus_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.aboutus_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.aboutus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutus_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutus_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutus_btn.Location = new System.Drawing.Point(3, 453);
            this.aboutus_btn.Name = "aboutus_btn";
            this.aboutus_btn.Size = new System.Drawing.Size(221, 53);
            this.aboutus_btn.TabIndex = 9;
            this.aboutus_btn.Text = "      About Us";
            this.aboutus_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.aboutus_btn.UseVisualStyleBackColor = true;
            // 
            // customer_btn
            // 
            this.customer_btn.FlatAppearance.BorderSize = 0;
            this.customer_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.customer_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.customer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customer_btn.Location = new System.Drawing.Point(0, 403);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(221, 53);
            this.customer_btn.TabIndex = 7;
            this.customer_btn.Text = "       Customer\'s Info";
            this.customer_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customer_btn.UseVisualStyleBackColor = true;
            // 
            // orders_btn
            // 
            this.orders_btn.FlatAppearance.BorderSize = 0;
            this.orders_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.orders_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.orders_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orders_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orders_btn.Location = new System.Drawing.Point(0, 358);
            this.orders_btn.Name = "orders_btn";
            this.orders_btn.Size = new System.Drawing.Size(221, 53);
            this.orders_btn.TabIndex = 5;
            this.orders_btn.Text = "       Orders";
            this.orders_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orders_btn.UseVisualStyleBackColor = true;
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
            // 
            // cashier
            // 
            this.cashier.AutoSize = true;
            this.cashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashier.ForeColor = System.Drawing.Color.Cornsilk;
            this.cashier.Location = new System.Drawing.Point(80, 134);
            this.cashier.Name = "cashier";
            this.cashier.Size = new System.Drawing.Size(61, 15);
            this.cashier.TabIndex = 1;
            this.cashier.Text = "@Cashier";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.orders1);
            this.panel2.Controls.Add(this.adminAddProducts1);
            this.panel2.Controls.Add(this.dashboard1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(221, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 767);
            this.panel2.TabIndex = 2;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1076, 767);
            this.dashboard1.TabIndex = 0;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1076, 767);
            this.adminAddProducts1.TabIndex = 1;
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
            // orders1
            // 
            this.orders1.Location = new System.Drawing.Point(0, 0);
            this.orders1.Name = "orders1";
            this.orders1.Size = new System.Drawing.Size(1076, 767);
            this.orders1.TabIndex = 2;
            // 
            // CashierMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 767);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CashierMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierMainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button aboutus_btn;
        private System.Windows.Forms.Button customer_btn;
        private System.Windows.Forms.Button orders_btn;
        private System.Windows.Forms.Button products_btn;
        private System.Windows.Forms.Button categories_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Label cashier;
        private System.Windows.Forms.Panel panel2;
        private AdminAddProducts adminAddProducts1;
        private Dashboard dashboard1;
        private Orders orders1;
    }
}