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

namespace LogInTest.Services
{

   public class DataValidationService
   {
      

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

      public User Find_The_User_And_Return_User_Instance(string inputEmail, List<User> inputList)
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

      private void btn_Click(object sender, EventArgs e)
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
