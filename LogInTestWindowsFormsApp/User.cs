using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInTestWindowsFormsApp
{
   public class User
   {
      private string _email;
      private string _password;
      private string _fullName;


      public User()
      {

      }

      public User(string email, string password)
      {
         this._email = email;
         this._password = password;
      }

      public User(string email, string password, string fullName)
      {
         this._email = email;
         this._password = password;
         this._fullName = fullName;
      }


      public string FullName
      {
         get { return _fullName; }
         set { _fullName = value; }
      }


      public string Email
      {
         get { return _email; }
         set { _email = value; }
      }

      public string Password
      {
         get { return _password; }
         set { _password = value; }
      }

   }
}
