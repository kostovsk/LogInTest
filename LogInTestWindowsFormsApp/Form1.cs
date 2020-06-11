using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInTestWindowsFormsApp
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
         txtEmail.KeyDown += textBox1_KeyDown;
         txtPassword.KeyDown += textBox2_KeyDown;
         txtPassword.PasswordChar = '●';
      }

      private void Form1_Load(object sender, EventArgs e)
      {
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {
      }

      private void textBox2_TextChanged(object sender, EventArgs e)
      {
      }

      private void textBox1_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            txtPassword.Focus();
         }
      }

      private void textBox2_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            btnLogIn.PerformClick();
         }
      }

      public static bool Is_Valid_Email(string email)
      {
         if (email != null)
         {
            return Regex.IsMatch(email, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
         }
         else
         {
            return false;
         }
      }

      public static User Find_The_User_And_Return_User_Instance(string inputEmail, List<User> inputList)
      {
         foreach (User user in inputList)
         {
            // find the user after the input is validated 
            if (inputEmail == user.Email)
            {
               return user;
            }
         }
         return null;
      }

      private void btnRegister_Click(object sender, EventArgs e)
      {
         AddUserForm addUserForm = new AddUserForm();
         addUserForm.ShowDialog();
      }

      public static readonly int maxFailedLoginAttempts = 3;

      int failedLoginAttempts = 0;
      int failedPassAttempts = 0;

      private void btnLogIn_Click(object sender, EventArgs e)
      {
         string inputUsername = txtEmail.Text;
         string inputPassword = txtPassword.Text;

         if (failedLoginAttempts < maxFailedLoginAttempts)
         {
            UserFactory newFactory = new UserFactory();
            List<User> newListJson = newFactory.Get_List_Of_Users_Json();

            User result = Find_The_User_And_Return_User_Instance(inputUsername, newListJson);


            if (Is_Valid_Email(inputUsername))
            {
               if (result != null)
               {
                  if (failedPassAttempts < maxFailedLoginAttempts)
                  {
                     if (result.Password == inputPassword)
                     {
                        MessageBox.Show("Login correct");
                        ProfilePage User_Profile_Page = new ProfilePage(result.FullName);
                        User_Profile_Page.ShowDialog();
                        Application.Exit();
                     }
                     else
                     {
                        failedPassAttempts += 1;
                        MessageBox.Show("Password is incorrect. Please try again:");
                        txtPassword.Text = String.Empty;
                        txtPassword.Focus();
                     }
                  }

               }
               else
               {
                  failedLoginAttempts += 1;
                  MessageBox.Show("Username is not in database. Please try again:");
                  txtEmail.Text = String.Empty;
                  txtPassword.Text = String.Empty;
                  txtEmail.Focus();
               }
            }
            else
            {
               failedLoginAttempts += 1;
               MessageBox.Show("Username is not an email. Please try again:");
               txtEmail.Text = String.Empty;
               txtPassword.Text = String.Empty;
               txtEmail.Focus();
            }
         }

         if (failedLoginAttempts >= 3 || failedPassAttempts >= 3)
         {
            Application.Exit();
         }

      }
   }
}










// old useless code

//public static bool isValidPassword(int userIndx, string pass)
//{
//   string[][] users = GetUserPasswordArray();

//   string passInDb = users[userIndx][1];
//   if (passInDb == pass)
//   {
//      return true;
//   }
//   else
//   {
//      return false;
//   }
//}


//public static int getUsernameIndex(string name)
//{
//   string[][] users = GetUserPasswordArray();

//   int positionInArray = -1;

//   for (int i = 0; i < users.Length; i++)
//   {
//      for (int j = 0; j < users[i].Length; j++)
//      {
//         if (users[i][j] == name)
//         {
//            positionInArray = i;
//            break;
//         }
//      }
//      if (positionInArray > -1)
//      {
//         break;
//      }
//   }
//   return positionInArray;
//}


//private static string[][] arr = null;
//private static string[][] GetUserPasswordArray()
//{
//   if (arr == null)
//   {
//      arr = new string[3][];

//      arr[0] = new string[2];
//      arr[0][0] = "kostovsk";
//      arr[0][1] = "123";

//      arr[1] = new string[2];
//      arr[1][0] = "skostov";
//      arr[1][1] = "456";


//      arr[2] = new string[2];
//      arr[2][0] = "stoichokostov";
//      arr[2][1] = "789";


//   }
//   return arr;
//}