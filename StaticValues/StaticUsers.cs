using DotNetCoreWithJwt.Model;
using System;
using System.Collections.Generic;

namespace DotNetCoreWithJwt.StaticValues
{
    public static class StaticUsers
    {
        public static List<User> StaticUsersList = new List<User>() {
            new User()
            {
                Id = Guid.NewGuid(),
                Name = "Ashok",
                Age = 23,
                UserDetail = new UserDetail()
                {
                    UserName = "ashok",
                    Password = "ashok"
                }
            },
            new User()
            {
                Id = Guid.NewGuid(),
                Name = "Sarathi",
                Age = 23,
                UserDetail = new UserDetail()
                {
                    UserName = "sarathi",
                    Password = "sarathi"
                }
            },
        };
    }
}
