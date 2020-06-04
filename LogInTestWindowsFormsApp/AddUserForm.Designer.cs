namespace LogInTestWindowsFormsApp
{
   partial class AddUserForm
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
         this.btnCreateUser = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.txtEmail = new System.Windows.Forms.TextBox();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtFullName = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // btnCreateUser
         // 
         this.btnCreateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.btnCreateUser.Location = new System.Drawing.Point(203, 216);
         this.btnCreateUser.Name = "btnCreateUser";
         this.btnCreateUser.Size = new System.Drawing.Size(101, 27);
         this.btnCreateUser.TabIndex = 0;
         this.btnCreateUser.Text = "Create User";
         this.btnCreateUser.UseVisualStyleBackColor = true;
         this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.label1.Location = new System.Drawing.Point(107, 96);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(76, 16);
         this.label1.TabIndex = 1;
         this.label1.Text = "Enter Email";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.label2.Location = new System.Drawing.Point(107, 133);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(102, 16);
         this.label2.TabIndex = 2;
         this.label2.Text = "Enter Password";
         // 
         // txtEmail
         // 
         this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.txtEmail.Location = new System.Drawing.Point(223, 96);
         this.txtEmail.Name = "txtEmail";
         this.txtEmail.Size = new System.Drawing.Size(155, 21);
         this.txtEmail.TabIndex = 3;
         this.txtEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // txtPassword
         // 
         this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.txtPassword.Location = new System.Drawing.Point(223, 133);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(155, 21);
         this.txtPassword.TabIndex = 4;
         this.txtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.label3.Location = new System.Drawing.Point(107, 173);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(103, 16);
         this.label3.TabIndex = 5;
         this.label3.Text = "Enter Full Name";
         // 
         // txtFullName
         // 
         this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.txtFullName.Location = new System.Drawing.Point(223, 173);
         this.txtFullName.Name = "txtFullName";
         this.txtFullName.Size = new System.Drawing.Size(155, 21);
         this.txtFullName.TabIndex = 6;
         this.txtFullName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
         // 
         // AddUserForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(488, 294);
         this.Controls.Add(this.txtFullName);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.txtEmail);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnCreateUser);
         this.Name = "AddUserForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "AddUser";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFullName;
    }
}