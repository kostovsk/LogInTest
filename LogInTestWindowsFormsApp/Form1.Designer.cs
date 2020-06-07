namespace LogInTestWindowsFormsApp
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
         this.txtEmail = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.username = new System.Windows.Forms.Label();
         this.password = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.btnRegister = new System.Windows.Forms.Button();
         this.btnLogIn = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtEmail
         // 
         this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.txtEmail.Location = new System.Drawing.Point(123, 84);
         this.txtEmail.Name = "txtEmail";
         this.txtEmail.Size = new System.Drawing.Size(172, 21);
         this.txtEmail.TabIndex = 0;
         this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // txtPassword
         // 
         this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.txtPassword.Location = new System.Drawing.Point(123, 124);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(172, 21);
         this.txtPassword.TabIndex = 1;
         this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
         // 
         // username
         // 
         this.username.AutoSize = true;
         this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.username.ForeColor = System.Drawing.SystemColors.ControlText;
         this.username.Location = new System.Drawing.Point(44, 84);
         this.username.Name = "username";
         this.username.Size = new System.Drawing.Size(42, 16);
         this.username.TabIndex = 3;
         this.username.Text = "Email";
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
         // btnRegister
         // 
         this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.btnRegister.Location = new System.Drawing.Point(123, 319);
         this.btnRegister.Name = "btnRegister";
         this.btnRegister.Size = new System.Drawing.Size(75, 23);
         this.btnRegister.TabIndex = 6;
         this.btnRegister.Text = "Register";
         this.btnRegister.UseVisualStyleBackColor = true;
         this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
         // 
         // btnLogIn
         // 
         this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.btnLogIn.Location = new System.Drawing.Point(161, 167);
         this.btnLogIn.Name = "btnLogIn";
         this.btnLogIn.Size = new System.Drawing.Size(84, 27);
         this.btnLogIn.TabIndex = 7;
         this.btnLogIn.Text = "Log In";
         this.btnLogIn.UseVisualStyleBackColor = true;
         this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(393, 361);
         this.Controls.Add(this.btnLogIn);
         this.Controls.Add(this.btnRegister);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.password);
         this.Controls.Add(this.username);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtEmail);
         this.Name = "Form1";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "LogIn";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
      public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogIn;
    }
}

