namespace PosInventorySystem
{
    partial class AdminAddUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adduser_dataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adduser_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adduser_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adduser_uname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.adduser_mnum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.adduser_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adduser_addbtn = new System.Windows.Forms.Button();
            this.adduser_updatebtn = new System.Windows.Forms.Button();
            this.adduser_clearbtn = new System.Windows.Forms.Button();
            this.adduser_removebtn = new System.Windows.Forms.Button();
            this.adduser_role = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adduser_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adduser_dataGrid);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 402);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.adduser_role);
            this.panel2.Controls.Add(this.adduser_removebtn);
            this.panel2.Controls.Add(this.adduser_clearbtn);
            this.panel2.Controls.Add(this.adduser_updatebtn);
            this.panel2.Controls.Add(this.adduser_addbtn);
            this.panel2.Controls.Add(this.adduser_mnum);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.adduser_email);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.adduser_pass);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.adduser_uname);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.adduser_ID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1048, 318);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // adduser_dataGrid
            // 
            this.adduser_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adduser_dataGrid.Location = new System.Drawing.Point(13, 15);
            this.adduser_dataGrid.Name = "adduser_dataGrid";
            this.adduser_dataGrid.Size = new System.Drawing.Size(1020, 373);
            this.adduser_dataGrid.TabIndex = 0;
            this.adduser_dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adduser_dataGrid_CellClick);
            this.adduser_dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adduser_dataGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manage Staff";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "StaffID";
            // 
            // adduser_ID
            // 
            this.adduser_ID.Location = new System.Drawing.Point(61, 80);
            this.adduser_ID.Name = "adduser_ID";
            this.adduser_ID.Size = new System.Drawing.Size(229, 20);
            this.adduser_ID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(58, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Role";
            // 
            // adduser_pass
            // 
            this.adduser_pass.Location = new System.Drawing.Point(408, 164);
            this.adduser_pass.Name = "adduser_pass";
            this.adduser_pass.Size = new System.Drawing.Size(229, 20);
            this.adduser_pass.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(405, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // adduser_uname
            // 
            this.adduser_uname.Location = new System.Drawing.Point(408, 80);
            this.adduser_uname.Name = "adduser_uname";
            this.adduser_uname.Size = new System.Drawing.Size(229, 20);
            this.adduser_uname.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(405, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Username";
            // 
            // adduser_mnum
            // 
            this.adduser_mnum.Location = new System.Drawing.Point(756, 164);
            this.adduser_mnum.Name = "adduser_mnum";
            this.adduser_mnum.Size = new System.Drawing.Size(229, 20);
            this.adduser_mnum.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(753, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mobile Number";
            // 
            // adduser_email
            // 
            this.adduser_email.Location = new System.Drawing.Point(756, 80);
            this.adduser_email.Name = "adduser_email";
            this.adduser_email.Size = new System.Drawing.Size(229, 20);
            this.adduser_email.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(753, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Email";
            // 
            // adduser_addbtn
            // 
            this.adduser_addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.adduser_addbtn.ForeColor = System.Drawing.Color.White;
            this.adduser_addbtn.Location = new System.Drawing.Point(277, 236);
            this.adduser_addbtn.Name = "adduser_addbtn";
            this.adduser_addbtn.Size = new System.Drawing.Size(93, 28);
            this.adduser_addbtn.TabIndex = 21;
            this.adduser_addbtn.Text = "Add";
            this.adduser_addbtn.UseVisualStyleBackColor = false;
            this.adduser_addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // adduser_updatebtn
            // 
            this.adduser_updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.adduser_updatebtn.ForeColor = System.Drawing.Color.White;
            this.adduser_updatebtn.Location = new System.Drawing.Point(419, 236);
            this.adduser_updatebtn.Name = "adduser_updatebtn";
            this.adduser_updatebtn.Size = new System.Drawing.Size(93, 28);
            this.adduser_updatebtn.TabIndex = 22;
            this.adduser_updatebtn.Text = "Update";
            this.adduser_updatebtn.UseVisualStyleBackColor = false;
            this.adduser_updatebtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // adduser_clearbtn
            // 
            this.adduser_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.adduser_clearbtn.ForeColor = System.Drawing.Color.White;
            this.adduser_clearbtn.Location = new System.Drawing.Point(560, 236);
            this.adduser_clearbtn.Name = "adduser_clearbtn";
            this.adduser_clearbtn.Size = new System.Drawing.Size(93, 28);
            this.adduser_clearbtn.TabIndex = 23;
            this.adduser_clearbtn.Text = "Clear";
            this.adduser_clearbtn.UseVisualStyleBackColor = false;
            this.adduser_clearbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // adduser_removebtn
            // 
            this.adduser_removebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.adduser_removebtn.ForeColor = System.Drawing.Color.White;
            this.adduser_removebtn.Location = new System.Drawing.Point(701, 236);
            this.adduser_removebtn.Name = "adduser_removebtn";
            this.adduser_removebtn.Size = new System.Drawing.Size(93, 28);
            this.adduser_removebtn.TabIndex = 24;
            this.adduser_removebtn.Text = "Remove";
            this.adduser_removebtn.UseVisualStyleBackColor = false;
            this.adduser_removebtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // adduser_role
            // 
            this.adduser_role.FormattingEnabled = true;
            this.adduser_role.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.adduser_role.Location = new System.Drawing.Point(61, 164);
            this.adduser_role.Name = "adduser_role";
            this.adduser_role.Size = new System.Drawing.Size(229, 21);
            this.adduser_role.TabIndex = 25;
            // 
            // AdminAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddUsers";
            this.Size = new System.Drawing.Size(1076, 767);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adduser_dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView adduser_dataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adduser_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adduser_uname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adduser_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adduser_mnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox adduser_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button adduser_removebtn;
        private System.Windows.Forms.Button adduser_clearbtn;
        private System.Windows.Forms.Button adduser_updatebtn;
        private System.Windows.Forms.Button adduser_addbtn;
        private System.Windows.Forms.ComboBox adduser_role;
    }
}
