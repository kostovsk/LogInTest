using System;
using System.Collections.Generic;
using System.Linq;
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

      public Dictionary<string, User> Dictionary_Of_Users()
      {
         Dictionary<string, User> dict_users = new Dictionary<string, User>();
         return dict_users;
      }
   }
}
