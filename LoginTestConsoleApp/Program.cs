﻿using System;
using System.Collections.Generic;

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

            foreach (string[] array in users)
            {
                foreach (string item in array)
                {
                    if (item.Contains(inputUsername))
                    {
                        Console.WriteLine("Username is correct.");
                    }
                    if (item.Contains(inputPassword))
                    {
                        Console.WriteLine("Password is correct.");
                    }
                }
            }

            for (int i = 0; i < users.Length; i++)
            {
                //System.Console.WriteLine("{0}", i);

                for (int j = 0; j < users[i].Length - 1; j++)
                {
                    //System.Console.WriteLine("{0}{1}", users[i][j], j == (users[i].Length - 1) ? "" : " ");
                    System.Console.WriteLine(users[i][j]);

                }
            }

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
