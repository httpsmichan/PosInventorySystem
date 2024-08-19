namespace PosInventorySystem
{
    partial class AdminAddCategories
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
            this.category_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.category_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.category_addbtn = new System.Windows.Forms.Button();
            this.category_removebtn = new System.Windows.Forms.Button();
            this.category_updatebtn = new System.Windows.Forms.Button();
            this.category_clearbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.category_ID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.category_clearbtn);
            this.panel1.Controls.Add(this.category_updatebtn);
            this.panel1.Controls.Add(this.category_removebtn);
            this.panel1.Controls.Add(this.category_addbtn);
            this.panel1.Controls.Add(this.category_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.category_ID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 733);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.category_grid);
            this.panel2.Location = new System.Drawing.Point(367, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 733);
            this.panel2.TabIndex = 1;
            // 
            // category_grid
            // 
            this.category_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.category_grid.Location = new System.Drawing.Point(17, 34);
            this.category_grid.Name = "category_grid";
            this.category_grid.Size = new System.Drawing.Size(658, 681);
            this.category_grid.TabIndex = 0;
            this.category_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.category_grid_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Manage Categories";
            // 
            // category_name
            // 
            this.category_name.Location = new System.Drawing.Point(49, 194);
            this.category_name.Name = "category_name";
            this.category_name.Size = new System.Drawing.Size(229, 20);
            this.category_name.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Category Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "All Categories";
            // 
            // category_addbtn
            // 
            this.category_addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.category_addbtn.ForeColor = System.Drawing.Color.White;
            this.category_addbtn.Location = new System.Drawing.Point(49, 497);
            this.category_addbtn.Name = "category_addbtn";
            this.category_addbtn.Size = new System.Drawing.Size(93, 28);
            this.category_addbtn.TabIndex = 22;
            this.category_addbtn.Text = "Add";
            this.category_addbtn.UseVisualStyleBackColor = false;
            this.category_addbtn.Click += new System.EventHandler(this.category_addbtn_Click);
            // 
            // category_removebtn
            // 
            this.category_removebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.category_removebtn.ForeColor = System.Drawing.Color.White;
            this.category_removebtn.Location = new System.Drawing.Point(49, 549);
            this.category_removebtn.Name = "category_removebtn";
            this.category_removebtn.Size = new System.Drawing.Size(93, 28);
            this.category_removebtn.TabIndex = 23;
            this.category_removebtn.Text = "Remove";
            this.category_removebtn.UseVisualStyleBackColor = false;
            this.category_removebtn.Click += new System.EventHandler(this.category_removebtn_Click);
            // 
            // category_updatebtn
            // 
            this.category_updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.category_updatebtn.ForeColor = System.Drawing.Color.White;
            this.category_updatebtn.Location = new System.Drawing.Point(192, 497);
            this.category_updatebtn.Name = "category_updatebtn";
            this.category_updatebtn.Size = new System.Drawing.Size(93, 28);
            this.category_updatebtn.TabIndex = 24;
            this.category_updatebtn.Text = "Update";
            this.category_updatebtn.UseVisualStyleBackColor = false;
            this.category_updatebtn.Click += new System.EventHandler(this.category_updatebtn_Click);
            // 
            // category_clearbtn
            // 
            this.category_clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.category_clearbtn.ForeColor = System.Drawing.Color.White;
            this.category_clearbtn.Location = new System.Drawing.Point(192, 549);
            this.category_clearbtn.Name = "category_clearbtn";
            this.category_clearbtn.Size = new System.Drawing.Size(93, 28);
            this.category_clearbtn.TabIndex = 25;
            this.category_clearbtn.Text = "Clear";
            this.category_clearbtn.UseVisualStyleBackColor = false;
            this.category_clearbtn.Click += new System.EventHandler(this.category_clearbtn_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "CategoryID";
            // 
            // category_ID
            // 
            this.category_ID.Location = new System.Drawing.Point(49, 115);
            this.category_ID.Name = "category_ID";
            this.category_ID.Size = new System.Drawing.Size(229, 20);
            this.category_ID.TabIndex = 12;
            // 
            // AdminAddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddCategories";
            this.Size = new System.Drawing.Size(1076, 767);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.category_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView category_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox category_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button category_clearbtn;
        private System.Windows.Forms.Button category_updatebtn;
        private System.Windows.Forms.Button category_removebtn;
        private System.Windows.Forms.Button category_addbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox category_ID;
    }
}
