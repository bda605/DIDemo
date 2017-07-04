using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX1_1
{
    class AuthenticationService
    {
        private IMessage msgService;
        public AuthenticationService(IMessage msgService)
        {
            this.msgService = msgService;
        }
        public bool TwoFactorLogin(string userId, string Pwd)
        {
            User user = CheckPassword(userId, Pwd);
            if (user != null) 
            {
                this.msgService.Send(user, "你的認證碼");
                return true;
            }
            return false;
        }
        public bool VerifyToken(string token) 
        {
            return true;
        }
        User CheckPassword(string UserId, string Pwd) 
        {
            var User = new User
            {
                UserId =UserId,
                Email = "bda605@gmail.com"
            };
            return User;
        }
     }
}
