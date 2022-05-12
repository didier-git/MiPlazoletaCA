using Microsoft.Extensions.DependencyInjection;
using Miplazoleta.Presenters;
using MiPlazoleta.UseCasePort.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.Presenters
{
    public static class DependencyContainar
    {
        public static IServiceCollection AddPresenterServices(this IServiceCollection services)
        {
            services.AddScoped<ICreatePlatoOutputPort, CreatePlatoPresenter>();
            services.AddScoped<IGetPlatosOutputPort, GetPlatosPresenter>();
            services.AddScoped<ICrearMenuOutputPort,CrearMenuPresenter>();
            services.AddScoped<IGetMenuOutputPort, GetMenuPresenter>();

            return services;
        }
    }
}
