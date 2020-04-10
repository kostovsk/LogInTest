using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogInTest.Services
{

   public class DataValidationService
   {
      /// <summary>
      /// Class constructor with no arguments
      /// </summary>
      public DataValidationService()
      {

      }

      /// <summary>
      /// Class constructor with 1 argument
      /// </summary>
      public DataValidationService(string userName, string password)
      {
         this._name = userName;
         this._password = password;
      }

      private string _name;
      private string _password;

      public string Name
      {
         //the getter
         get { return _name; }

         //the setter
         set { _name = value; }
      }

      public string Password
      {
        get { return _password; }
        
        set { _password = value; }
      }


      /// <summary>
      /// A method that takes 0 argumens and returns a List (which a equivalent ot Java's ArrayList)
      /// </summary>
      /// <returns></returns>
      public List<UserProfile> UserProfiles()
      {
         List<UserProfile> firstList = new List<UserProfile>();
         var user1 = new UserProfile();
         user1.Name = "kostovsk";
         user1.Password = "123";
         firstList.Add(user1);

         var user2 = new UserProfile();
         user2.Name = "skostov";
         user2.Password = "456";
         firstList.Add(user2);

         var user3 = new UserProfile();
         user3.Name = "stoichokostov";
         user3.Password = "789";
         firstList.Add(user3);

         return firstList;

      }

      /// <summary>
      /// A method that takes 0 argumens and returns an Array
      /// </summary>
      /// <returns></returns>
      public UserProfile[] UserProfilesArray()
      {
         UserProfile[] theArray = new UserProfile[3];
         var user1 = new UserProfile();
         user1.Name = "kostovsk";
         user1.Password = "123";
         theArray[0] =  user1;

         var user2 = new UserProfile();
         user2.Name = "skostov";
         user2.Password = "456";
         theArray[1] = user2;

         var user3 = new UserProfile();
         user3.Name = "stoichokostov";
         user3.Password = "789";
         theArray[2] = user3;

         return theArray;

      }
   }
  
}
