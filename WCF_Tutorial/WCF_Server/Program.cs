using System;
using System.ServiceModel;
using WCF_Server.Service;
using CoreWCF;
using CoreWCF.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddServiceModelServices();

        var app = builder.Build();
        app.UseServiceModel(serviceBuilder =>
        {
            serviceBuilder.AddService<HelloService>();
            serviceBuilder.AddServiceEndpoint<HelloService, IHelloService>(
                new BasicHttpBinding(), "/HelloService");
        });

        app.Run();
    }
}