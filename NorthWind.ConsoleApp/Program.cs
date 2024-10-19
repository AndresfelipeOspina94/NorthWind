
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extension.DependencyInjection;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices();


using IHost AppHost = Builder.Build();


IAppLogger logger = AppHost.Services.GetRequiredService<IAppLogger>();
logger.WriteLog("Application started.");

IProductService Service = AppHost.Services.GetRequiredService <IProductService>();
Service.Add("Demo", "Azucar refinada");

