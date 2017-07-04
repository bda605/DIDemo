using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX1_1
{
    class ShortMessageService:IMessage
    {
        public void Send(User user, string msg)
        {
            Console.WriteLine("手機簡訊發送內容:" + msg);
        }
    }
}
