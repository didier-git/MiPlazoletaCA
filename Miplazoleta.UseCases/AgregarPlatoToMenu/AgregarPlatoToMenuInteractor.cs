using Miplazoleta.DTOs.DTOs;
using Miplazoleta.UseCasePort.Ports;
using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.Entities.Interfaces;
using MiPlazoleta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.UseCases.AgregarPlatoToMenu
{
    public class AgregarPlatoToMenuInteractor : IAddPlatoToMenuInputPort
    {
        public readonly IRepositorioMenu ContextMenu;
        public readonly IRepositorioPlato ContextPlato; 
        public readonly IUnitOfWork UnitOfWork;
        public readonly IRepositorioPlatoMenu ContextPlatoMenu;
        public readonly IAgregarPlatoToMenuOutputPort OutputPort;

        public AgregarPlatoToMenuInteractor
            (IRepositorioMenu contextMenu, IRepositorioPlato contextPlato
            , IUnitOfWork unitOfWork, IAgregarPlatoToMenuOutputPort outputPort, IRepositorioPlatoMenu contextPlatoMenu) => 
            (ContextMenu, ContextPlato, UnitOfWork, OutputPort, ContextPlatoMenu) = 
            (contextMenu, contextPlato, unitOfWork, outputPort, contextPlatoMenu);
       
        public async Task Handle(int idMenu, int IdPlato)
        {
            var Menu = ContextMenu.GetMenu(idMenu);
            var Plato = ContextPlato.GetPlato(IdPlato);

            PlatoMenu NewPlatoMenu = new()
            {
                MenuId = Menu.IdMenu,
                PlatoId = Plato.IdPlato,
                Menu = Menu,
                Plato = Plato,
            };

            
            ContextPlatoMenu.AddPlatoMenu(NewPlatoMenu);
            
            
            PlatoMenuAddDto PlatoMenuNew = new()
            {
                IdMenu = NewPlatoMenu.MenuId,
                IdPlato = NewPlatoMenu.PlatoId

            };
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle(PlatoMenuNew);
           
        }
    }
}
