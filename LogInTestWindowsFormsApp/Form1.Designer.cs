﻿namespace LogInTestWindowsFormsApp
{
    partial class Form1
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
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
         this.username = new System.Windows.Forms.Label();
         this.password = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.button2 = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // textBox1
         // 
         this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.textBox1.Location = new System.Drawing.Point(123, 84);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(172, 21);
         this.textBox1.TabIndex = 0;
         this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // textBox2
         // 
         this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.textBox2.Location = new System.Drawing.Point(123, 124);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(172, 21);
         this.textBox2.TabIndex = 1;
         this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
         // 
         // button1
         // 
         this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.button1.Location = new System.Drawing.Point(168, 169);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 2;
         this.button1.Text = "Log In";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // username
         // 
         this.username.AutoSize = true;
         this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.username.ForeColor = System.Drawing.SystemColors.ControlText;
         this.username.Location = new System.Drawing.Point(44, 84);
         this.username.Name = "username";
         this.username.Size = new System.Drawing.Size(71, 16);
         this.username.TabIndex = 3;
         this.username.Text = "Username";
         // 
         // password
         // 
         this.password.AutoSize = true;
         this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.password.Location = new System.Drawing.Point(44, 124);
         this.password.Name = "password";
         this.password.Size = new System.Drawing.Size(68, 16);
         this.password.TabIndex = 4;
         this.password.Text = "Password";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.label1.Location = new System.Drawing.Point(31, 319);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(79, 16);
         this.label1.TabIndex = 5;
         this.label1.Text = "Not a User?";
         // 
         // button2
         // 
         this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.button2.Location = new System.Drawing.Point(123, 319);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 6;
         this.button2.Text = "Register";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(393, 361);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.password);
         this.Controls.Add(this.username);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "LogIn";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
      public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

