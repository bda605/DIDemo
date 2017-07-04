using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX1_1
{
    interface IMessage
    {
        void Send(User user, string msg);
    }
}
