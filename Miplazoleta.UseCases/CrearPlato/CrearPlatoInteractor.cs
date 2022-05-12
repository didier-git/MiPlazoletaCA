using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.UseCasePort.Ports;
using MiPlazoleta.Entities.Interfaces;
using MiPlazoleta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MiPlazoleta.UseCases.CrearPlato
{
    public class CrearPlatoInteractor : ICreatePlatoInputPort
    {
        public readonly IRepositorioPlato Repositorio;
        public readonly IUnitOfWork UnitOfWork;
        public readonly ICreatePlatoOutputPort OutputPort;

        //public readonly IServiceProvider ServiceProvider;

        public CrearPlatoInteractor(
            IRepositorioPlato repositorio, IUnitOfWork unitOfWork, ICreatePlatoOutputPort outputPort)
            => (Repositorio, UnitOfWork, OutputPort) = (repositorio, unitOfWork, outputPort);
        //public CrearPlatoInteractor(IServiceProvider serviceProvider)=>ServiceProvider=serviceProvider;


        public async Task Handle(CrearPlatoDTO plato)
        {
            //using IServiceScope scope = ServiceProvider.CreateScope();  

            //IServiceProvider serviceProvider = scope.ServiceProvider;

            //var Repositorio = serviceProvider.GetRequiredService<IRepositorioPlato>();
            //var OutputPort = serviceProvider.GetRequiredService<ICreatePlatoOutputPort>();
            //var UnitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>(); 
            
            
            Plato NewPlato = new()
            {
                Nombre = plato.Nombre,
                Descripcion = plato.Descripcion,
                precio = plato.precio

            };

            Repositorio.Crear(NewPlato);
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle(new PlatoDTO
            {
                Id = NewPlato.IdPlato,
                Nombre = NewPlato.Nombre,
                Descripcion = NewPlato.Descripcion,
                Precio = NewPlato.precio

            });
        }
    }
}
