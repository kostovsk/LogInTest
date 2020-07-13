using LogInTest.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LogInTest.Services
{
   public class UserService
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
      }

      public void SaveUsers(List<User> userList)
      {
         using (StreamWriter file = File.CreateText(@"..\..\Data\users.json"))
         {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(file, userList);
         }
      }
   }
}
