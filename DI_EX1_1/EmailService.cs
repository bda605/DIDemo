using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX1_1
{
    class EmailService:IMessage
    {
        public void Send(User user, string msg) 
        {
            Console.WriteLine("Email發送:" + msg);
        }
    }
}
