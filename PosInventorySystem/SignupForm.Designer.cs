﻿namespace PosInventorySystem
{
    partial class SignupForm
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
            this.signup_showPass = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signup_cpassword = new System.Windows.Forms.TextBox();
            this.loginlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_btn = new System.Windows.Forms.Button();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.signup_showPass);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.signup_cpassword);
            this.panel1.Controls.Add(this.loginlabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.signup_password);
            this.panel1.Controls.Add(this.signup_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 516);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 253);
            this.panel1.TabIndex = 3;
            // 
            // signup_showPass
            // 
            this.signup_showPass.AutoSize = true;
            this.signup_showPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.signup_showPass.Location = new System.Drawing.Point(682, 174);
            this.signup_showPass.Name = "signup_showPass";
            this.signup_showPass.Size = new System.Drawing.Size(102, 17);
            this.signup_showPass.TabIndex = 9;
            this.signup_showPass.Text = "Show Password";
            this.signup_showPass.UseVisualStyleBackColor = true;
            this.signup_showPass.CheckedChanged += new System.EventHandler(this.signup_showPass_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cornsilk;
            this.label5.Location = new System.Drawing.Point(556, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirm Password";
            // 
            // signup_cpassword
            // 
            this.signup_cpassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.signup_cpassword.ForeColor = System.Drawing.SystemColors.Window;
            this.signup_cpassword.Location = new System.Drawing.Point(556, 148);
            this.signup_cpassword.Name = "signup_cpassword";
            this.signup_cpassword.PasswordChar = '*';
            this.signup_cpassword.Size = new System.Drawing.Size(231, 20);
            this.signup_cpassword.TabIndex = 7;
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.Color.Red;
            this.loginlabel.Location = new System.Drawing.Point(1160, 201);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(76, 16);
            this.loginlabel.TabIndex = 6;
            this.loginlabel.Text = "Log In Here";
            this.loginlabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(1029, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Already a member?";
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.signup_btn.Location = new System.Drawing.Point(607, 201);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(123, 37);
            this.signup_btn.TabIndex = 4;
            this.signup_btn.Text = "Sign Up";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signup_password
            // 
            this.signup_password.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.signup_password.ForeColor = System.Drawing.Color.AliceBlue;
            this.signup_password.Location = new System.Drawing.Point(556, 87);
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(231, 20);
            this.signup_password.TabIndex = 3;
            // 
            // signup_username
            // 
            this.signup_username.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.signup_username.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.signup_username.Location = new System.Drawing.Point(556, 32);
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(231, 20);
            this.signup_username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(553, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(553, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PosInventorySystem.Properties.Resources.FuntilonLogo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 772);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 767);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SignupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point-of-Sale (POS) with Inventory and Supply Management for Funtilon Hardware an" +
    "d Construction Supplies";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox signup_cpassword;
        private System.Windows.Forms.CheckBox signup_showPass;
    }
}