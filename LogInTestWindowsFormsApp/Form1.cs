﻿using System;
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


            /*####################################*/
            #region "Examples"

            UserFactory factory = new UserFactory();

            //option 1:
            List<User> listOfUsersFromFactory = factory.MakeAndReturnAListOfUsers();

            //option 2:
            List<User> listOfUsersPassedByReference = new List<User>();
            factory.PopulateListOfUsers(listOfUsersPassedByReference);

            int testCountFirstList = listOfUsersFromFactory.Count;
            int testCountSecondList = listOfUsersPassedByReference.Count;

            #endregion "Examples"
            /*####################################*/



            int indexOfUserName = getUsernameIndex(inputUsername);
            if (indexOfUserName > -1)
            {
               userNameIsValid = true;
            }


            if (userNameIsValid == true)
            {

               if (failedPassAttempts < maxFailedLoginAttempts)
               {
                  passwordIsValid = isValidPassword(indexOfUserName, inputPassword);
                  if (passwordIsValid)
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

         if (failedLoginAttempts >= 3 || failedPassAttempts >= 3)
         {
            Application.Exit();
         }

      }

      public static Users()
      {
         List<User> UserList = new List<User>();
         UserList.Add(new User("kostovsk", "123"));
         UserList.Add(new User("skostov", "456"));
         UserList.Add(new User("stoichokostov", "789"));

         return;
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
   }
}