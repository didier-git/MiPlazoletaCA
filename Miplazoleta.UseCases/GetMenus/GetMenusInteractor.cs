using Microsoft.Extensions.DependencyInjection;
using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.Entities.Interfaces;
using MiPlazoleta.Entities.POCOs;
using MiPlazoleta.UseCasePort.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.UseCases.GetMenus
{
    public class GetMenusInteractor : IGetMenuInputPort

    {
        public readonly IRepositorioMenu Repositorio;
        public readonly IGetMenuOutputPort OutputPort;
        //public readonly IServiceProvider ServiceProvider;   

        public GetMenusInteractor(IRepositorioMenu repositorio, IGetMenuOutputPort outputPort)
            => (Repositorio, OutputPort) = (repositorio, outputPort);

        //public GetMenusInteractor(IServiceProvider serviceProvider)=>ServiceProvider= serviceProvider;
        public async Task Handle()
        {
            //using IServiceScope scope = ServiceProvider.CreateScope();

            //IServiceProvider serviceProvider = scope.ServiceProvider;

            //var Repositorio = serviceProvider.GetRequiredService<IRepositorioMenu>(); 
            //var OutputPort = serviceProvider.GetRequiredService<IGetMenuOutputPort>();    


            var Menus = Repositorio.GetMenus().Select(m => new MenuDTO
            {
                Id = m.IdMenu,  
                Nombre = m.Nombre,
                Descripcion = m.Descripcion,
            });

            await OutputPort.Handle(Menus);

        }
    }
}
