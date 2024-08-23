namespace PosInventorySystem
{
    partial class Orders
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
            this.label1 = new System.Windows.Forms.Label();
            this.order_Gridview1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.order_qty = new System.Windows.Forms.NumericUpDown();
            this.order_prodID = new System.Windows.Forms.ComboBox();
            this.order_clearbtn = new System.Windows.Forms.Button();
            this.order_removebtn = new System.Windows.Forms.Button();
            this.order_addbtn = new System.Windows.Forms.Button();
            this.order_Cat = new System.Windows.Forms.ComboBox();
            this.order_price = new System.Windows.Forms.Label();
            this.order_Remstock = new System.Windows.Forms.Label();
            this.order_prodName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.order_Printreceipt = new System.Windows.Forms.Button();
            this.order_PayOrder = new System.Windows.Forms.Button();
            this.order_Cashamount = new System.Windows.Forms.TextBox();
            this.order_Change = new System.Windows.Forms.Label();
            this.order_Totalprice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_Gridview1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_qty)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.order_Gridview1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 426);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Available Products";
            // 
            // order_Gridview1
            // 
            this.order_Gridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.order_Gridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_Gridview1.Location = new System.Drawing.Point(14, 30);
            this.order_Gridview1.Name = "order_Gridview1";
            this.order_Gridview1.Size = new System.Drawing.Size(661, 379);
            this.order_Gridview1.TabIndex = 2;
            this.order_Gridview1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.order_Gridview1_CellClick);
            this.order_Gridview1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.order_Gridview1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(706, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 377);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.order_qty);
            this.panel2.Controls.Add(this.order_prodID);
            this.panel2.Controls.Add(this.order_clearbtn);
            this.panel2.Controls.Add(this.order_removebtn);
            this.panel2.Controls.Add(this.order_addbtn);
            this.panel2.Controls.Add(this.order_Cat);
            this.panel2.Controls.Add(this.order_price);
            this.panel2.Controls.Add(this.order_Remstock);
            this.panel2.Controls.Add(this.order_prodName);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(13, 447);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 305);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // order_qty
            // 
            this.order_qty.Location = new System.Drawing.Point(70, 210);
            this.order_qty.Name = "order_qty";
            this.order_qty.Size = new System.Drawing.Size(229, 20);
            this.order_qty.TabIndex = 32;
            // 
            // order_prodID
            // 
            this.order_prodID.FormattingEnabled = true;
            this.order_prodID.Location = new System.Drawing.Point(70, 139);
            this.order_prodID.Name = "order_prodID";
            this.order_prodID.Size = new System.Drawing.Size(229, 21);
            this.order_prodID.TabIndex = 31;
            this.order_prodID.SelectedIndexChanged += new System.EventHandler(this.order_prodID_SelectedIndexChanged);
            // 
            // order_clearbtn
            // 
            this.order_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.order_clearbtn.ForeColor = System.Drawing.Color.White;
            this.order_clearbtn.Location = new System.Drawing.Point(475, 258);
            this.order_clearbtn.Name = "order_clearbtn";
            this.order_clearbtn.Size = new System.Drawing.Size(93, 28);
            this.order_clearbtn.TabIndex = 30;
            this.order_clearbtn.Text = "Clear";
            this.order_clearbtn.UseVisualStyleBackColor = false;
            this.order_clearbtn.Click += new System.EventHandler(this.order_clearbtn_Click);
            // 
            // order_removebtn
            // 
            this.order_removebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.order_removebtn.ForeColor = System.Drawing.Color.White;
            this.order_removebtn.Location = new System.Drawing.Point(578, 258);
            this.order_removebtn.Name = "order_removebtn";
            this.order_removebtn.Size = new System.Drawing.Size(93, 28);
            this.order_removebtn.TabIndex = 28;
            this.order_removebtn.Text = "Remove";
            this.order_removebtn.UseVisualStyleBackColor = false;
            this.order_removebtn.Click += new System.EventHandler(this.order_removebtn_Click);
            // 
            // order_addbtn
            // 
            this.order_addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.order_addbtn.ForeColor = System.Drawing.Color.White;
            this.order_addbtn.Location = new System.Drawing.Point(373, 258);
            this.order_addbtn.Name = "order_addbtn";
            this.order_addbtn.Size = new System.Drawing.Size(93, 28);
            this.order_addbtn.TabIndex = 27;
            this.order_addbtn.Text = "Add";
            this.order_addbtn.UseVisualStyleBackColor = false;
            this.order_addbtn.Click += new System.EventHandler(this.category_addbtn_Click);
            // 
            // order_Cat
            // 
            this.order_Cat.FormattingEnabled = true;
            this.order_Cat.Location = new System.Drawing.Point(70, 72);
            this.order_Cat.Name = "order_Cat";
            this.order_Cat.Size = new System.Drawing.Size(229, 21);
            this.order_Cat.TabIndex = 26;
            this.order_Cat.SelectedIndexChanged += new System.EventHandler(this.order_Cat_SelectedIndexChanged);
            // 
            // order_price
            // 
            this.order_price.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.order_price.AutoSize = true;
            this.order_price.BackColor = System.Drawing.Color.White;
            this.order_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_price.ForeColor = System.Drawing.Color.Black;
            this.order_price.Location = new System.Drawing.Point(440, 204);
            this.order_price.Name = "order_price";
            this.order_price.Size = new System.Drawing.Size(105, 16);
            this.order_price.TabIndex = 25;
            this.order_price.Text = "Product Name";
            // 
            // order_Remstock
            // 
            this.order_Remstock.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.order_Remstock.AutoSize = true;
            this.order_Remstock.BackColor = System.Drawing.Color.White;
            this.order_Remstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_Remstock.ForeColor = System.Drawing.Color.Black;
            this.order_Remstock.Location = new System.Drawing.Point(491, 139);
            this.order_Remstock.Name = "order_Remstock";
            this.order_Remstock.Size = new System.Drawing.Size(105, 16);
            this.order_Remstock.TabIndex = 24;
            this.order_Remstock.Text = "Product Name";
            // 
            // order_prodName
            // 
            this.order_prodName.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.order_prodName.AutoSize = true;
            this.order_prodName.BackColor = System.Drawing.Color.White;
            this.order_prodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_prodName.ForeColor = System.Drawing.Color.Black;
            this.order_prodName.Location = new System.Drawing.Point(475, 72);
            this.order_prodName.Name = "order_prodName";
            this.order_prodName.Size = new System.Drawing.Size(105, 16);
            this.order_prodName.TabIndex = 23;
            this.order_prodName.Text = "Product Name";
            // 
            // label9
            // 
            this.label9.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(373, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Price (₱):";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(373, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Product Name:";
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(373, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Remaining Stock:";
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(67, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(67, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "ProductID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Browse Product";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(67, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Category";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel4
            // 
            this.panel4.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.order_Printreceipt);
            this.panel4.Controls.Add(this.order_PayOrder);
            this.panel4.Controls.Add(this.order_Cashamount);
            this.panel4.Controls.Add(this.order_Change);
            this.panel4.Controls.Add(this.order_Totalprice);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(709, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 737);
            this.panel4.TabIndex = 2;
            // 
            // order_Printreceipt
            // 
            this.order_Printreceipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.order_Printreceipt.ForeColor = System.Drawing.Color.White;
            this.order_Printreceipt.Location = new System.Drawing.Point(74, 668);
            this.order_Printreceipt.Name = "order_Printreceipt";
            this.order_Printreceipt.Size = new System.Drawing.Size(205, 28);
            this.order_Printreceipt.TabIndex = 35;
            this.order_Printreceipt.Text = "Print Receipt";
            this.order_Printreceipt.UseVisualStyleBackColor = false;
            // 
            // order_PayOrder
            // 
            this.order_PayOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.order_PayOrder.ForeColor = System.Drawing.Color.White;
            this.order_PayOrder.Location = new System.Drawing.Point(74, 636);
            this.order_PayOrder.Name = "order_PayOrder";
            this.order_PayOrder.Size = new System.Drawing.Size(205, 28);
            this.order_PayOrder.TabIndex = 31;
            this.order_PayOrder.Text = "Pay Order/s";
            this.order_PayOrder.UseVisualStyleBackColor = false;
            this.order_PayOrder.Click += new System.EventHandler(this.order_PayOrder_Click);
            // 
            // order_Cashamount
            // 
            this.order_Cashamount.Location = new System.Drawing.Point(155, 503);
            this.order_Cashamount.Name = "order_Cashamount";
            this.order_Cashamount.Size = new System.Drawing.Size(151, 20);
            this.order_Cashamount.TabIndex = 31;
            this.order_Cashamount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.order_Cashamount_KeyDown);
            // 
            // order_Change
            // 
            this.order_Change.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.order_Change.AutoSize = true;
            this.order_Change.BackColor = System.Drawing.Color.White;
            this.order_Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_Change.ForeColor = System.Drawing.Color.Black;
            this.order_Change.Location = new System.Drawing.Point(126, 551);
            this.order_Change.Name = "order_Change";
            this.order_Change.Size = new System.Drawing.Size(35, 16);
            this.order_Change.TabIndex = 34;
            this.order_Change.Text = "0.00";
            // 
            // order_Totalprice
            // 
            this.order_Totalprice.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.order_Totalprice.AutoSize = true;
            this.order_Totalprice.BackColor = System.Drawing.Color.White;
            this.order_Totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_Totalprice.ForeColor = System.Drawing.Color.Black;
            this.order_Totalprice.Location = new System.Drawing.Point(141, 459);
            this.order_Totalprice.Name = "order_Totalprice";
            this.order_Totalprice.Size = new System.Drawing.Size(105, 16);
            this.order_Totalprice.TabIndex = 31;
            this.order_Totalprice.Text = "Product Name";
            // 
            // label12
            // 
            this.label12.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(40, 551);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Change (₱): ";
            // 
            // label11
            // 
            this.label11.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(40, 505);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Cash Amount (₱):";
            // 
            // label10
            // 
            this.label10.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(40, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Total Price (₱):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "All Order/s";
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(706, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(344, 377);
            this.panel5.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(325, 379);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Orders";
            this.Size = new System.Drawing.Size(1076, 767);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_Gridview1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_qty)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView order_Gridview1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label order_prodName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox order_Cat;
        private System.Windows.Forms.Label order_price;
        private System.Windows.Forms.Label order_Remstock;
        private System.Windows.Forms.Button order_clearbtn;
        private System.Windows.Forms.Button order_removebtn;
        private System.Windows.Forms.Button order_addbtn;
        private System.Windows.Forms.Button order_Printreceipt;
        private System.Windows.Forms.Button order_PayOrder;
        private System.Windows.Forms.TextBox order_Cashamount;
        private System.Windows.Forms.Label order_Change;
        private System.Windows.Forms.Label order_Totalprice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox order_prodID;
        private System.Windows.Forms.NumericUpDown order_qty;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
