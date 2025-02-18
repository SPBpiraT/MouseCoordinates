﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace MouseCoordinates.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
