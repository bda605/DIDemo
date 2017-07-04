using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_EX1_1
{
    static class MyDIContainer
    {
        private static Dictionary<string, Type> typeMap;
        static MyDIContainer() 
        {
            typeMap = new Dictionary<string, Type>();
            typeMap.Add("EmailService", typeof(EmailService));
            typeMap.Add("ShortMessageService", typeof(ShortMessageService));

        }
        public static object Reslove(string typeName) 
        {
          var resovedType = typeMap[typeName];
          object instance = Activator.CreateInstance(resovedType);
          return instance;
        }
    }
}
