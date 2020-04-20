using System;
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

            //TODO: 
            //Consider case where the username is not in the database

            //HINT: 
            //Break the logic down into functions: 
            //1. The first function can return a value 
            //   that has the coordinates ([i][j]) of the inputUsername in the users array


            for (int i = 0; i < users.Length; i++)
            {
                for (int j = 0; j < users[i].Length; j++)
                {
                    //If true, user exists in the database
                    if (users[i][j] == inputUsername)
                    {
                        //Let's asume that in our case, password is always the second entry
                        string passwordInOurDatabase = users[i][j + 1];
                        if (passwordInOurDatabase == inputPassword)
                        {
                            Console.WriteLine("Login correct");
                        }
                        else
                        {
                            Console.WriteLine("Password is incorrect");
                            //TODO: tell the user the password is incorrect
                        }

                    }
                }
            }

            //if (userNameIndx != null){
            // pass on indexof username to a var
            //var userNameIndx = validateUsername(inputUsername);
            //}
            //call a second method that takes index to verify password
            //validatePassword(userNameIndx, inputPassword);
            //else{
            //Console.WriteLine("The username is not in the database");
            //}

            Console.ReadLine();
        }

        public void validateUsername(string name)
        {
            string[][] users = GetUserPasswordArray();

            for (int i = 0; i < users.Length; i++)
            {
                for (int j = 0; j < users[i].Length; j++)
                {
                    //If true, user exists in the database
                    if (users[i][j] == name)
                    {
                        //return indexOf
                        Console.WriteLine(Array.IndexOf(users, name));
                    }
                }
            }
        }

        public void validatePassword(string userIndx, string pass)
        {
            string[][] users = GetUserPasswordArray();
            //determine how to pass index of username, add 1 element to
            //assign string name to it and verify if 

            //Let's asume that in our case, password is always the second entry
            string passwordInOurDatabase = users[userIndx + 1][j + 1];
            if (passwordInOurDatabase == pass)
            {
                Console.WriteLine("Login correct");
            }
            else
            {
                Console.WriteLine("Password is incorrect");
                //TODO: tell the user the password is incorrect
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
