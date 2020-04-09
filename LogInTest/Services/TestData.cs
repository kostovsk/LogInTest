using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogInTest.Services
{

   public class SomeClassNameSuchAs_DataValidationService
   {
      /// <summary>
      /// Class constructor with no arguments
      /// </summary>
      public SomeClassNameSuchAs_DataValidationService()
      {

      }

      /// <summary>
      /// Class constructor with 1 argument
      /// </summary>
      public SomeClassNameSuchAs_DataValidationService(int someValuePassedHere)
      {
         this._exampleOfAField = someValuePassedHere;
      }

      private int _exampleOfAField;

      public int JustAnExampleOfAPublicProperty
      {
         //the getter
         get { return _exampleOfAField; }

         //the setter
         set { _exampleOfAField = value; }
      }


      /// <summary>
      /// A method that takes 0 argumens and returns a List (which a equivalent ot Java's ArrayList)
      /// </summary>
      /// <returns></returns>
      public List<TestDataClass> UserProfiles()
      {
         List<TestDataClass> firstList = new List<TestDataClass>();
         var user1 = new TestDataClass();
         user1.Name = "kostovsk";
         user1.Password = "123";
         firstList.Add(user1);

         var user2 = new TestDataClass();
         user2.Name = "skostov";
         user2.Password = "456";
         firstList.Add(user2);

         var user3 = new TestDataClass();
         user3.Name = "stoichokostov";
         user3.Password = "789";
         firstList.Add(user3);

         return firstList;

      }

      /// <summary>
      /// A method that takes 0 argumens and returns an Array
      /// </summary>
      /// <returns></returns>
      public TestDataClass[] UserProfilesArray()
      {
         TestDataClass[] theArray = new TestDataClass[3];
         var user1 = new TestDataClass();
         user1.Name = "kostovsk";
         user1.Password = "123";
         theArray[0] =  user1;

         var user2 = new TestDataClass();
         user2.Name = "skostov";
         user2.Password = "456";
         theArray[1] = user2;

         var user3 = new TestDataClass();
         user3.Name = "stoichokostov";
         user3.Password = "789";
         theArray[2] = user3;

         return theArray;

      }
   }
  
}
