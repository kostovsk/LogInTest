using System;
using System.Collections.Generic;
using System.Text;

namespace LoginTestConsoleApp
{
   public class User
   {
      private string name;
      private string pass;

      public User(string name, string pass)
      {
         this.name = name;
         this.pass = pass;
      }

      public string Name
      {
         get { return name; }
         set { name = value; }
      }

      public string Pass
      {
         get { return pass; }
         set { pass = value; }
      }

   }
}
