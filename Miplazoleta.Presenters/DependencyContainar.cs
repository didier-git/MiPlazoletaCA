using Microsoft.Extensions.DependencyInjection;
using Miplazoleta.UseCasePort.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.Presenters
{
    public static class DependencyContainar
    {
        public static IServiceCollection AddPresenterServices(this IServiceCollection services)
        {
            services.AddScoped<ICreatePlatoOutputPort, CreatePlatoPresenter>();
            services.AddScoped<IGetPlatosOutputPort, GetPlatosPresenter>();

            return services;
        }
    }
}
