using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogInTest.Services
{
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
}
