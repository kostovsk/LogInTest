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
         textBox1.KeyDown += textBox1_KeyDown;
         textBox2.KeyDown += textBox2_KeyDown;
         textBox2.PasswordChar = '●';
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
            textBox2.Focus();
         }
      }

      private void textBox2_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.KeyCode == Keys.Enter)
         {
            button1.PerformClick();
         }
      }

      public static readonly int maxFailedLoginAttempts = 3;

      bool userNameIsValid = false;
      bool passwordIsValid = false;
      int failedLoginAttempts = 0;
      int failedPassAttempts = 0;

      private void button1_Click(object sender, EventArgs e)
      {

         string inputUsername = textBox1.Text;
         string inputPassword = textBox2.Text;

         if (failedLoginAttempts < maxFailedLoginAttempts)
         {

            //UserFactory factory = new UserFactory();
            //List<User> listOfUsersFromFactory = factory.MakeAndReturnAListOfUsers();
            //factory.PopulateListOfUsers(listOfUsersFromFactory);

            UserFactory addUsers = new UserFactory();
            Dictionary<string, User> dictOfUsersFromUserFactory = addUsers.Dictionary_Of_Users();

            User result = Find_The_User_And_Return_User_Instance(inputUsername, dictOfUsersFromUserFactory);
            // either use a method or integrate in Find and return user method
            // using mail class to validate

            if (Is_Valid_Email(inputUsername))
            {
               if (result != null)
               {
                  if (failedPassAttempts < maxFailedLoginAttempts)
                  {
                     if (result.Password == inputPassword)
                     {
                        MessageBox.Show("Login correct");
                        ProfilePage p = new ProfilePage(textBox1.Text);
                        p.ShowDialog();
                        Application.Exit();
                     }
                     else
                     {
                        failedPassAttempts += 1;
                        MessageBox.Show("Password is incorrect. Please try again:");
                        textBox2.Text = String.Empty;
                        textBox2.Focus();
                     }
                  }

               }
               else
               {
                  failedLoginAttempts += 1;
                  MessageBox.Show("Username is not in database. Please try again:");
                  textBox1.Text = String.Empty;
                  textBox2.Text = String.Empty;
                  textBox1.Focus();
               }
            }
            else
            {
               failedLoginAttempts += 1;
               MessageBox.Show("Username is not an email. Please try again:");
               textBox1.Text = String.Empty;
               textBox2.Text = String.Empty;
               textBox1.Focus();
            }
         }

         if (failedLoginAttempts >= 3 || failedPassAttempts >= 3)
         {
            Application.Exit();
         }

      }

      public static int getUsernameIndex(string name)
      {
         string[][] users = GetUserPasswordArray();

         int positionInArray = -1;

         for (int i = 0; i < users.Length; i++)
         {
            for (int j = 0; j < users[i].Length; j++)
            {
               if (users[i][j] == name)
               {
                  positionInArray = i;
                  break;
               }
            }
            if (positionInArray > -1)
            {
               break;
            }
         }
         return positionInArray;
      }

      public static bool Is_Valid_Email(string email)
      {
         if(email != null)
         {
            return Regex.IsMatch(email, @"(@)(.+)$");
         }
         else
         {
            return false; 
         }
      }

      public static User Find_The_User_And_Return_User_Instance(string inputName, Dictionary<string, User> inputList)
      {
         foreach (KeyValuePair<string, User> user in inputList)
         {
            // find the user after the input is validated 
            if (inputName == user.Value.Email)
            {
               return user.Value;
            }
         }
         return null;
      }

      public static bool isValidPassword(int userIndx, string pass)
      {
         string[][] users = GetUserPasswordArray();

         string passInDb = users[userIndx][1];
         if (passInDb == pass)
         {
            return true;
         }
         else
         {
            return false;
         }
      }

      private static string[][] arr = null;
      private static string[][] GetUserPasswordArray()
      {
         if (arr == null)
         {
            arr = new string[3][];

            arr[0] = new string[2];
            arr[0][0] = "kostovsk";
            arr[0][1] = "123";

            arr[1] = new string[2];
            arr[1][0] = "skostov";
            arr[1][1] = "456";


            arr[2] = new string[2];
            arr[2][0] = "stoichokostov";
            arr[2][1] = "789";


         }
         return arr;
      }



      private void btnRegister_Click(object sender, EventArgs e)
      {
         AddUserForm addUserForm = new AddUserForm();
         addUserForm.ShowDialog();
      }
   }
}