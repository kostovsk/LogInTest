using LogInTest.Models;
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
         
      }

      public static readonly int maxFailedLoginAttempts = 3;

      int failedLoginAttempts = 0;
      int failedPassAttempts = 0;

      private void btn_Click(object sender, EventArgs e)
      {
         string inputUsername = "";
         string inputPassword = "";

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
                        
                     }
                     else
                     {
                        
                     }
                  }

               }
               else
               {
                  
               }
            }
            else
            {
               
            }
         }

         if (failedLoginAttempts >= 3 || failedPassAttempts >= 3)
         {
            
         }

      }

   }

}
