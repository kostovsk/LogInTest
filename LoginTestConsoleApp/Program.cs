using System;
using System.Collections.Generic;

namespace LoginTestConsoleApp
{
   class Program
   {
      public static readonly int maxFailedLoginAttempts = 3;

      static void Main(string[] args)
      {
         bool userNameIsValid = false;
         bool passwordIsValid = false;
         int failedLoginAttempts = 0;
         

         Console.WriteLine("Enter your username:");
         string inputUsername = Console.ReadLine();

         Console.WriteLine("Enter your password:");
         string inputPassword = Console.ReadLine();
         


         int indexOfUserName = getUsernameIndex(inputUsername);
         if (indexOfUserName > -1)
         {
            userNameIsValid = true;
         }
         

         if (userNameIsValid == true)
         {
            passwordIsValid = isValidPassword(indexOfUserName, inputPassword);
            if (passwordIsValid)
            {
               Console.WriteLine("Login correct");
            }
            else
            {
               Console.WriteLine("Password is incorrect");
               /*
                * 1. Promp the user to re-enter password
                * 2. Try to add logic where you can limit bad entries to up to three attempts
                */
            }
         }
         else
         {
            Console.WriteLine("Username is not in database");
            /*
             * 1. Promp the user to re-enter username
             * 2. Try to add logic where you can limit bad entries to up to three attempts
             */
         }

         Console.ReadLine();
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

      public static void validatePassword(int userIndx, string pass)
      {
         string[][] users = GetUserPasswordArray();

         string passInDb = users[userIndx][1];
         if (passInDb == pass)
         {
            Console.WriteLine("Login correct");
         }
         else
         {
            Console.WriteLine("Password is incorrect");
         }
         return;
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

      private static string[][] GetUserPasswordArray()
      {
         string[][] arr = new string[3][];

         arr[0] = new string[2];
         arr[0][0] = "kostovsk";
         arr[0][1] = "123";

         arr[1] = new string[2];
         arr[1][0] = "skostov";
         arr[1][1] = "456";


         arr[2] = new string[2];
         arr[2][0] = "stoichokostov";
         arr[2][1] = "789";

         return arr;
      }

   }
}
