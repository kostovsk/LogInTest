using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LogInTestWindowsFormsApp
{
   public class UsersService
   {
      public List<User> GetUsers()
      {
         using (StreamReader file = File.OpenText(@"..\..\Data\users.json"))
         {
            string jsonText = file.ReadToEnd();
            JsonSerializer serializer = new JsonSerializer();
            List<User> theDeserializedListOfUsers = JsonConvert.DeserializeObject<List<User>>(jsonText);
            return theDeserializedListOfUsers;
         }
         return null;
      }

      public void SaveUsers(List<User> userList)
      {
         var test = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
         using (StreamWriter file = File.CreateText(@"..\..\Data\users.json"))
         {
            JsonSerializer serializer = new JsonSerializer();
            //serialize object directly into file stream
            serializer.Serialize(file, userList);
         }
      }


   }
}
