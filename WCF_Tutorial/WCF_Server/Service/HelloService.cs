using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreWCF;

namespace WCF_Server.Service
{
    public class HelloService : IHelloService
    {
        public string SayHello(string name)
        {
            return $"Hi, I'm {name}. WCF Test Success";
        }
    }
}
