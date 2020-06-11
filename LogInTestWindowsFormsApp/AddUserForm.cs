using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInTestWindowsFormsApp
{
   public partial class AddUserForm : Form
   {
      public AddUserForm()
      {
         InitializeComponent();
         txtEmail.KeyDown += txtEmail_KeyDown;
         txtPassword.KeyDown += txtPassword_KeyDown;
         txtFullName.KeyDown += txtFullName_KeyDown;
         txtPassword.PasswordChar = '●';
      }

      private void textBox2_TextChanged(object sender, EventArgs e)
      {

      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {
         txtEmail.Focus();
      }

      private void textBox3_TextChanged(object sender, EventArgs e)
      {

      }

      private void txtEmail_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            txtPassword.Focus();
         }
      }

      private void txtPassword_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            txtFullName.Focus();
         }
      }

      private void txtFullName_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            btnCreateUser.PerformClick();
         }
      }
      /*
       * ####### Code review note ##########
       *
       * Make sure to name your form elements and functions appropriately
       * so you can find them in the code when your code base grows larger
       */
      private void btnCreateUser_Click(object sender, EventArgs e)
      {
         string addEmail = txtEmail.Text;
         string addPassword = txtPassword.Text;
         string addFullname = txtFullName.Text;

         User newUser = new User();
         newUser.Email = addEmail;
         newUser.Password = addPassword;
         newUser.FullName = addFullname;

         List<User> newListFromInput = new List<User>();
         newListFromInput.Add(newUser);

         UserFactory userFactory = new UserFactory();
         List<User> listOfUsersFromJson = userFactory.Get_List_Of_Users_Json();

         bool stopForLoop = true;

         if (stopForLoop)
         {
            foreach (User item in listOfUsersFromJson)
            {
               if (addEmail == item.Email)
               {
                  MessageBox.Show("The user already exists.");
                  txtEmail.Text = String.Empty;
                  txtPassword.Text = String.Empty;
                  txtFullName.Text = String.Empty;
                  txtEmail.Focus();
                  stopForLoop = false;
               }
            }
         }
         else
         {
            userFactory.Save_User_To_New_List(newListFromInput);
            MessageBox.Show("Add another user.");
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtFullName.Text = String.Empty;
            txtEmail.Focus();
            stopForLoop = true;
         }

         

         /*
          *####### Code review note ##########
          *
          * Avoid using try-catch for simple logical operations
          * https://docs.microsoft.com/en-us/dotnet/standard/exceptions/best-practices-for-exceptions
          *
          */



         /*
          * TODO:
          * Apply proper KEY check for Dictionary such as .ContainsKey
          * https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2.containskey?view=netframework-4.8#examples
          *
          */


         //UserFactory userFactory = new UserFactory();
         //Dictionary<string, User> dictOfUsersFromUserFactory = userFactory.Dictionary_Of_Users();
         //if (dictOfUsersFromUserFactory.ContainsKey(newUser.Email))
         //{
         //   MessageBox.Show("The user already exists.");
         //   txtEmail.Text = String.Empty;
         //   txtPassword.Text = String.Empty;
         //   txtFullName.Text = String.Empty;
         //   txtEmail.Focus();
         //}
         //else
         //{
         //   dictOfUsersFromUserFactory.Add(newUser.Email, newUser);
         //   Form1 New_Log_In_Form = new Form1();
         //   New_Log_In_Form.ShowDialog();
         //}

      }

   }
}
