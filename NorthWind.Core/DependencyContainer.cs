﻿using Microsoft.Extensions.DependencyInjection;
using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extension.DependencyInjection;

public static class DependencyContainer
{
    public static IServiceCollection AddServices(
        this IServiceCollection services)
    {
        services.AddSingleton<IAppLogger, AppLogger>();
        services.AddSingleton < IProductService, ProductService>();
        return services;
    }

}
