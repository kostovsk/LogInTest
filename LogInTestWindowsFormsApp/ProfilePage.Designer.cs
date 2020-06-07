namespace LogInTestWindowsFormsApp
{
   partial class ProfilePage
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
         this.label1 = new System.Windows.Forms.Label();
         this.lblUserEmail = new System.Windows.Forms.Label();
         this.btnCancel = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
         this.label1.Location = new System.Drawing.Point(45, 72);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(91, 24);
         this.label1.TabIndex = 1;
         this.label1.Text = "Welcome";
         // 
         // lblUserEmail
         // 
         this.lblUserEmail.AutoSize = true;
         this.lblUserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
         this.lblUserEmail.Location = new System.Drawing.Point(142, 72);
         this.lblUserEmail.Name = "lblUserEmail";
         this.lblUserEmail.Size = new System.Drawing.Size(49, 24);
         this.lblUserEmail.TabIndex = 2;
         this.lblUserEmail.Text = "User";
         // 
         // btnCancel
         // 
         this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
         this.btnCancel.Location = new System.Drawing.Point(146, 124);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(82, 28);
         this.btnCancel.TabIndex = 3;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // ProfilePage
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(362, 250);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.lblUserEmail);
         this.Controls.Add(this.label1);
         this.Name = "ProfilePage";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ProfilePage";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Button btnCancel;
    }
}