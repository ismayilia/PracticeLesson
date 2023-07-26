using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccountSercive
    {
        public bool Login(string username, string password)
        {
            var dbUsers= GetUsers();
            foreach (var user in dbUsers) 
            {

                if (user.UserName==username && user.Password==password)
                {
                    return true;
                }

            }
            return false;
        }


        private User[] GetUsers()
        {
            User[] users =
            {
                new User
            {
                Id = 1,
                UserName="ismayil55",
                Password= "ismayil123"
            },

                 new User
            {
                Id = 2,
                UserName="xeyyam55",
                Password= "xeyyam123"
            },
                new User
            {
                Id = 3,
                UserName="pervin55",
                Password= "pervin123"
            }
            };

            return users;
        }
    }
}
