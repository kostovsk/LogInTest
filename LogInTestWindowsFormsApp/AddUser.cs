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
   public partial class AddUser : Form
   {
      public AddUser()
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
         string addUsername = textBox1.Text;
         string addPassword = textBox2.Text;
         string addFullname = textBox3.Text;

         UserFactory addUsers = new UserFactory();
         Dictionary<string, User> p = addUsers.Dictionary_Of_Users();
         
         try
         {
            p.Add(addUsername, new User(addUsername, addPassword, addFullname);
         }
         catch
         {
            return ;
         }
      }

      
   }
}
