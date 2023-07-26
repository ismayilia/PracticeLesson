using Domain.Models;
using Service.Helpers;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson.Controllers
{
    public class AccountController
    {
        private readonly AccountSercive _accountSercive;
        public AccountController()
        {
            _accountSercive = new AccountSercive();
        }



        public void Login()
        {
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Password: ");
            Username:  string password = Console.ReadLine();

            bool isLogin = _accountSercive.Login(username,password);

            if (isLogin)
            {
                Console.WriteLine(AccountMessages.LoginSucces);
            }
            else
            {
                Console.WriteLine(AccountMessages.LoginFailed);
                goto Username;
            }
        }
    }
}
