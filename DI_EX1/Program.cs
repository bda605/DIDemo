using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    //DI第一支範例
    interface IMessageServie 
    {
        void Send(User user, string msg);
    }

    class EmailService : IMessageServie 
    {
        public void Send(User user, string msg) 
        {
            Console.WriteLine("寄送郵件,內容為:" + msg);
        }
    }
    class ShortMessageService : IMessageServie 
    {
        public void Send(User user, string msg)
        {
            Console.WriteLine("寄送簡訊,內容為:" + msg);
        }
    }
    class AuthenticationService 
    {
        private IMessageServie msgService;
        public AuthenticationService(IMessageServie msgService) 
        {
            this.msgService = msgService;
        }
        public bool ToFactorLogin(string UserId, string Pwd) 
        {
            User user = CheckPassword(UserId, Pwd);
            if (user != null) 
            {
                this.msgService.Send(user,"你的驗證碼123456");
                return true;
            }
            return false;
        }
        public  bool VerifyToken(string token)
        {
            return true;
        }
        User CheckPassword(string UserId, string Pwd) 
        {
            var user = new User()
            {
                UserId = UserId,
                Email = "bda605@gmail.com"
            };
            return user;
        }
    }
    class User 
    {
        public string UserId;
        public string Email;
        public string CellPhone;
    }
    class MainApp 
    {
        public void Login(string userId, string pwd, string messageServiceType) 
        {
            IMessageServie msgService = null;
            switch (messageServiceType) 
            {
                case "EmailService":
                    msgService = new EmailService();
                    break;
                case "ShortMessageService":
                    msgService = new ShortMessageService();
                    break;
            }
            AuthenticationService authService = new AuthenticationService(msgService);
            if (authService.ToFactorLogin(userId, pwd)) 
            {
                string userInputToken = "123456";
                if (authService.VerifyToken(userInputToken)) 
                {
                   //ok
                }
            }
            //Error
        }
    }
}
