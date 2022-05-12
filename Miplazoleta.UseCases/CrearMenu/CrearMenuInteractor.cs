using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.UseCasePort.Ports;
using MiPlazoleta.Entities.Interfaces;
using MiPlazoleta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miplazoleta.DTOs.DTOs;
using Microsoft.Extensions.DependencyInjection;

namespace MiPlazoleta.UseCases.CrearMenu
{
    public class CrearMenuInteractor : ICrearMenuInputPort
    {
        public readonly IRepositorioMenu Repositorio;
        public readonly IUnitOfWork UnitOfWork;
        public readonly ICrearMenuOutputPort OutputPort;
        //public readonly IServiceProvider ServiceProvider;

        public CrearMenuInteractor(IRepositorioMenu repositorio, IUnitOfWork unitOfWork, ICrearMenuOutputPort outputPort) =>
            (Repositorio, UnitOfWork, OutputPort) = (repositorio, unitOfWork, outputPort);


        /* public CrearMenuInteractor(IRepositorioMenu repositorio, IUnitOfWork unitOfWork, IServiceProvider serviceProvider) =>
    (Repositorio, UnitOfWork, ServiceProvider) = (repositorio, unitOfWork, serviceProvider);*/

        //public CrearMenuInteractor(IServiceProvider serviceProvider) => ServiceProvider = serviceProvider;
        public async Task Handle(CrearMenuDTO menu)
        {
            Menu NewMenu = new Menu
            {
                Nombre = menu.Nombre,
                Descripcion = menu.Descripcion
            };

            //var scope = ServiceProvider.CreateScope();
            //var OutputPort = scope.ServiceProvider.GetRequiredService<ICrearMenuOutputPort>();

            // Configuro el alcance de los sercicios
            //using IServiceScope scope = ServiceProvider.CreateScope();
            //IServiceProvider serviceProvider = scope.ServiceProvider;
            //var OutputPort = serviceProvider.GetRequiredService<ICrearMenuOutputPort>();
            //var Repositorio = serviceProvider.GetRequiredService<IRepositorioMenu>();   
            //var UnitOfWork = serviceProvider.GetRequiredService<IUnitOfWork>(); 
            
            Repositorio.CrearMenu(NewMenu);
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle(new MenuDTO
            {
                Id = NewMenu.IdMenu,
                Nombre = NewMenu.Nombre,
                Descripcion = NewMenu.Descripcion,
            });
           
        }
    }
}
