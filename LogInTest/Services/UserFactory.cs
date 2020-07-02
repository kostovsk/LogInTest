using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogInTest.Services
{
   public class UserFactory
   {
      public List<User> Get_List_Of_Users_Json()
      {
         UserService userService = new UserService();
         List<User> dictOfUsersFromJson = userService.GetUsers();

         return dictOfUsersFromJson;
      }

      public void Save_User_To_New_List(List<User> newList)
      {
         UserService userService = new UserService();
         userService.SaveUsers(newList);

      }
   }
}
