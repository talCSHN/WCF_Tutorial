using System;
using System.ServiceModel; // 클라이언트는 System.ServiceModel.Http 패키지 사용
// 프로젝트에 System.ServiceModel.Http 패키지 참조 필요

[ServiceContract]
public interface IHelloService
{
    [OperationContract]
    string SayHello(string name);
}

class Program
{
    static void Main()
    {
        var factory = new ChannelFactory<IHelloService>(
            new BasicHttpBinding(),
            new EndpointAddress("http://localhost:65000/HelloService"));

        var proxy = factory.CreateChannel();
        Console.WriteLine(proxy.SayHello("박관호"));
    }
}
