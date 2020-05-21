using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInTestWindowsFormsApp
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
