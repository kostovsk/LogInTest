﻿namespace LogInTestWindowsFormsApp
{
   partial class AddUser
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
         this.button1 = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.button1.Location = new System.Drawing.Point(203, 216);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(101, 27);
         this.button1.TabIndex = 0;
         this.button1.Text = "Create User";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.label1.Location = new System.Drawing.Point(104, 96);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(105, 16);
         this.label1.TabIndex = 1;
         this.label1.Text = "Enter Username";
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
         // textBox1
         // 
         this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.textBox1.Location = new System.Drawing.Point(223, 96);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(155, 21);
         this.textBox1.TabIndex = 3;
         this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
         // 
         // textBox2
         // 
         this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.textBox2.Location = new System.Drawing.Point(223, 133);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(155, 21);
         this.textBox2.TabIndex = 4;
         this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.label3.Location = new System.Drawing.Point(110, 173);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(103, 16);
         this.label3.TabIndex = 5;
         this.label3.Text = "Enter Full Name";
         // 
         // textBox3
         // 
         this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.textBox3.Location = new System.Drawing.Point(223, 173);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(155, 21);
         this.textBox3.TabIndex = 6;
         this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
         // 
         // AddUser
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(488, 294);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.button1);
         this.Name = "AddUser";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "AddUser";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}