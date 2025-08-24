using System;
using System.Collections.Generic;
using System.Linq;
//using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using CoreWCF;

namespace WCF_Server.Service
{
    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        string SayHello(string name);
    }
}
