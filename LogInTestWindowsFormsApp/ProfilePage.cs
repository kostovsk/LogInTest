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
   public partial class ProfilePage : Form
   {
      
      public ProfilePage(string text)
      {
         InitializeComponent();
         label2.Text = text;
      }

      private void button1_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }
   }
}
