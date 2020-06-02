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

      private void button1_Click(object sender, EventArgs e)
      {
         string addEmail = textBox1.Text;
         string addPassword = textBox2.Text;
         string addFullname = textBox3.Text;

         UserFactory addUsers = new UserFactory();
         Dictionary<string, User> dictOfUsersFromUserFactory = addUsers.Dictionary_Of_Users();

         //User newUser = new User(addEmail, addPassword, addFullname);
         //dictOfUsersFromUserFactory.Add(newUser.Email, newUser);

         try
         {
            User newUser = new User(addEmail, addPassword, addFullname);
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
