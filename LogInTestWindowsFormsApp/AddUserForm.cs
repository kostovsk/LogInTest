using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInTestWindowsFormsApp
{
   public partial class AddUserForm : Form
   {
      public AddUserForm()
      {
         InitializeComponent();
      }

      private void textBox2_TextChanged(object sender, EventArgs e)
      {

      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }

      private void textBox3_TextChanged(object sender, EventArgs e)
      {

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

         UserFactory userFactory = new UserFactory();
         Dictionary<string, User> dictOfUsersFromUserFactory = userFactory.Dictionary_Of_Users();

         User newUser = new User(addEmail, addPassword, addFullname);


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

         try
         {
            dictOfUsersFromUserFactory.Add(newUser.Email, newUser);
         }
         catch (ArgumentException)
         {
            MessageBox.Show("The user already exists.");
         }
         
         Form1 b = new Form1();
         b.ShowDialog();
         
      }
   }
}
