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
         int failedPassAttempts = 0;

         List<User> UserList = new List<User>();

         User user1 = new User("kostovsk", "123");
         UserList.Add(user1);

         User user2 = new User("skostov", "456");
         UserList.Add(user2);

         User user3 = new User("stoichokostov", "789");
         UserList.Add(user3);

         foreach (var user in UserList)
         {
            Console.WriteLine(user);
         }

         //UserList.Add(new User("kostovsk", "123"));
         //UserList.Add(new User("skostov", "456"));
         //UserList.Add(new User("stoichokostov", "789"));

         Console.WriteLine();

         Console.WriteLine("Enter your username:");
         string inputUsername = Console.ReadLine();

         Console.WriteLine("Enter your password:");
         string inputPassword = Console.ReadLine();

         while (failedLoginAttempts <= maxFailedLoginAttempts)
         {
            int indexOfUserName = getUsernameIndex(inputUsername);
            if (indexOfUserName > -1)
            {
               userNameIsValid = true;
            }


            if (userNameIsValid == true)
            {

               while (failedPassAttempts <= maxFailedLoginAttempts)
               {
                  passwordIsValid = isValidPassword(indexOfUserName, inputPassword);
                  if (passwordIsValid)
                  {
                     Console.WriteLine("Login correct");
                     break;
                  }
                  else
                  {
                     failedPassAttempts += 1;
                     Console.WriteLine();
                     Console.WriteLine("Password is incorrect. Please try again:");
                     inputPassword = Console.ReadLine();
                  }
               }
               break;
            }
            else
            {
               failedLoginAttempts += 1;
               Console.WriteLine();
               Console.WriteLine("Username is not in database. Please try again:");
               inputUsername = Console.ReadLine();

            }
         }

         Console.ReadLine();
      }


      public static string enterUser()
      {
         Console.WriteLine("Enter your username:");
         string inputUsername = Console.ReadLine();
         return inputUsername;
      }

      public static string enterPass()
      {
         Console.WriteLine("Enter your password:");
         string inputPassword = Console.ReadLine();
         return inputPassword;
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
