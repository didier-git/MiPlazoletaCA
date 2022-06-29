using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Miplazoleta.Controllers;
using Miplazoleta.UseCasePort.Ports;
using Miplazoleta.UseCases.AgregarPlatoToMenu;
using Miplazoleta.UseCases.DeleteMenu;
using Miplazoleta.UseCases.DeletePlato;
using Miplazoleta.UseCases.GetMenuPlatos;
using Miplazoleta.UseCases.GetMenus;
using MiPlazoleta.Controllers;
using MiPlazoleta.UseCasePort.Ports;
using MiPlazoleta.UseCases.CrearMenu;
using MiPlazoleta.UseCases.CrearPlato;
using MiPlazoleta.UseCases.GetPlatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUsecasesServices(this IServiceCollection services){



            services.AddTransient<ICrearMenuInputPort, CrearMenuInteractor>()
                    .AddTransient<IGetMenuInputPort, GetMenusInteractor>()
                    .AddTransient<ICreatePlatoInputPort, CrearPlatoInteractor>()
                    .AddTransient<IGetPlatosInputPort, GetPlatosInteractor>()
                    .AddTransient<IAddPlatoToMenuInputPort, AgregarPlatoToMenuInteractor>()
                    .AddTransient<IGetMenuPlatosInputPort, GetMenuPlatosInteractor>()
                    .AddTransient<IDeletePlatoInputPort, DeletePlatoInteractor>()
                    .AddTransient<IDeleteMenuInputPort, DeleteMenuInteractor>();
           

            return services;
        
        
        }
    }
}
