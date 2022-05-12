using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.RepositorioEFcore.Repositorios;
using MiPlazoleta.UseCasePort.Ports;
using MiPlazoleta.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiPlazoleta.Entities.POCOs;
using Microsoft.Extensions.DependencyInjection;

namespace MiPlazoleta.UseCases.GetPlatos
{
    public class GetPlatosInteractor : IGetPlatosInputPort
    {

        public readonly IRepositorioPlato Repositorio;
        public readonly IGetPlatosOutputPort OutputPort;

        //public readonly IServiceProvider ServiceProvider;

        public GetPlatosInteractor(IRepositorioPlato repositorio, IGetPlatosOutputPort outputPort) => (Repositorio, OutputPort) = (repositorio, outputPort);

        //public GetPlatosInteractor(IServiceProvider serviceProvider)=>ServiceProvider=serviceProvider;
       
        
        public  Task Handle()
        {
            //using IServiceScope Scope = ServiceProvider.CreateScope();
            //IServiceProvider serviceProvider = Scope.ServiceProvider;  
            
            //var Repositorio = ServiceProvider.GetRequiredService<IRepositorioPlato>();
            //var OutputPort = ServiceProvider.GetRequiredService<IGetPlatosOutputPort>();
            var platos = Repositorio.GetAll().Select(p => new PlatoDTO
            {
                Id = p.IdPlato,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Precio = p.precio


            });

            OutputPort.Handler(platos);
            return Task.CompletedTask;
        }
    }
}
