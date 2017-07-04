using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX1_1
{
    class MainApp
    {
        public void Login(string userId, string Pwd,string MessageServiceType) 
        {
            var msgService = (IMessage)MyDIContainer.Reslove(MessageServiceType);
            var authService = new AuthenticationService(msgService);
            if (authService.TwoFactorLogin(userId, Pwd)) 
            {
                string userInputToken = "123456";
                if (authService.VerifyToken(userInputToken)) 
                {
                
                }
            }
        }
    }
}
