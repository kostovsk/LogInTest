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

            int result = validateUsername(inputUsername);

            Console.WriteLine(result);

            Console.WriteLine(users[result][1]);

            bool userNameIsValid;

            if (result > -1)
            {
                userNameIsValid = true;
                if (userNameIsValid == true)
                {
                    //for (int j = 1; j < users[result].Length; j++)

                    string passInDb = users[result][1];
                    if (passInDb == inputPassword)
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
            else
            {
                Console.WriteLine("Username is not in database");
            }

            //TODO: 
            //Consider case where the username is not in the database

            //HINT: 
            //Break the logic down into functions: 
            //1. The first function can return a value 
            //   that has the coordinates ([i][j]) of the inputUsername in the users array

            //this will be replaced by the if statement
            //for (int i = 0; i < users.Length; i++)
            //{
            //    for (int j = 0; j < users[i].Length; j++)
            //    {
            //        //If true, user exists in the database
            //        if (users[i][j] == inputUsername)
            //        {
            //            //Let's asume that in our case, password is always the second entry
            //            string passwordInOurDatabase = users[i][j + 1];
            //            if (passwordInOurDatabase == inputPassword)
            //            {
            //                Console.WriteLine("Login correct");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Password is incorrect");
            //                //TODO: tell the user the password is incorrect
            //            }

            //        }
            //    }
            //}

            //if (userNameIndx != null){
            // pass on indexof username to a var
            // var userNameIndx = validateUsername(inputUsername);
            //}
            //call a second method that takes index to verify password
            //validatePassword(userNameIndx, inputPassword);
            //else{
            //Console.WriteLine("The username is not in the database");
            //}

            Console.ReadLine();
        }

        public static int validateUsername(string name)
        {
            string[][] users = GetUserPasswordArray();

            int positionInArray = -1;
            //int defaultReturnValue = -1;

            for (int i = 0; i < users.Length; i++)
            {
                for (int j = 0; j < users[i].Length; j++)
                {
                    //If true, user exists in the database
                    if (users[i][j] == name)
                    {
                        //return indexOf
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
            //determine how to pass index of username, add 1 element to
            //assign string name to it and verify if 
            for (int j = 0; j < users[userIndx].Length; j++)
            {
                string passInDb = users[userIndx][j + 1];
                if (passInDb == pass)
                {
                    Console.WriteLine("Login correct");
                }
                else
                {
                    Console.WriteLine("Password is incorrect");
                    //TODO: tell the user the password is incorrect
                }
            }
            return;
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
