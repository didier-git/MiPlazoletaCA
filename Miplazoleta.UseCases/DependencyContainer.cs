using Microsoft.Extensions.DependencyInjection;
using Miplazoleta.UseCasePort.Ports;
using Miplazoleta.UseCases.CrearPlato;
using Miplazoleta.UseCases.GetPlatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUsecasesServices(this IServiceCollection services){

            services.AddTransient<ICreatePlatoInputPort, CrearPlatoInteractor>();
            services.AddTransient<IGetPlatosInputPort, GetPlatosInteractor>();

            return services;
        
        }
    }
}
