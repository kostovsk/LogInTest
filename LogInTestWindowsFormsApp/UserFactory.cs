using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogInTestWindowsFormsApp
{
   public class UserFactory
   {

      /// <summary>
      /// Method that creates a list of users and returs it
      /// </summary>
      /// <returns>Returns List of <see cref="List{User}"/> </returns>
      public List<User> MakeAndReturnAListOfUsers()
      {
         List<User> userList = new List<User>();
         userList.Add(new User("kostovsk@gmail.com", "123"));
         userList.Add(new User("skostov@gmail.com", "456"));
         userList.Add(new User("stoichokostov@gmail.com", "789"));
         return userList;
      }

      /// <summary>
      /// A void method that doesn't return anything. 
      /// Intead it populates the reference type of <see cref="List{User}"/> that's passed passed by reference
      /// </summary>
      /// <param name="listOfUsers"></param>
      public void PopulateListOfUsers(List<User> listOfUsers)
      {
         listOfUsers.Add(new User("kostovsk3@gmail.com", "1011"));
         listOfUsers.Add(new User("skostov2@gmail.com", "1271"));
         listOfUsers.Add(new User("stoichokostov4@gmail.com", "6191"));
      }

      public List<User> Get_List_Of_Users_Json()
      {         
         UsersService userService = new UsersService();
         List<User> dictOfUsersFromJson = userService.GetUsers();

         return dictOfUsersFromJson;
      }

      public void Save_User_To_New_List(List<User> newList)
      {
         UsersService userService = new UsersService();
         userService.SaveUsers(newList);

      }

   }
}


//Dictionary<string, User> dict_users = new Dictionary<string, User>();

////Example 1:
//User userEmample1 = new User("kostovsk@gmail.com", "123");
//dict_users.Add(userEmample1.Email, userEmample1);

////Example 2 *passing fullName value to override contructor:
//User userEmample2 = new User("skostov2@gmail.com", "1271", "Stoicho Kostov");
//dict_users.Add(userEmample2.Email, userEmample2);

////Example 3 *using default contructor and then setting parameter values:
//User userEmample3 = new User();
//userEmample3.Email = "Chase@gmail.com";
//userEmample3.Password = "bacon";
//userEmample3.FullName = "Chase Kostov";
//dict_users.Add(userEmample3.Email, userEmample3);

//TODO: add additional users:
