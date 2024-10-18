
using Microsoft.Extensions.Hosting;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extension.DependencyInjection;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices();

Builder.Services.AddSingleton<AppLogger>();
Builder.Services.AddSingleton<ProductService>();
using IHost AppHost = Builder.Build();


AppLogger logger = AppHost.Services.GetRequiredService<AppLogger>();
logger.WriteLog("Application started.");

ProductService Service = AppHost.Services.GetRequiredService <ProductService>();
Service.Add("Demo", "Azucar refinada");

