using System;

namespace LoginTestConsoleApp
{
   class Program
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Enter your username:");
         string inputUsername = Console.ReadLine();

         Console.WriteLine("Enter your password:");
         string inputPassword = Console.ReadLine();

         string[][] users = GetUserPasswordArray();

         //TODO: write your code here to check inputUsername and inputPassword against the values in the users array
         Console.ReadLine();
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
