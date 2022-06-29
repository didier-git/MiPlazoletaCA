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
        
        public readonly IAgregarPlatoToMenuOutputPort OutputPort;

        public AgregarPlatoToMenuInteractor
            (IRepositorioMenu contextMenu, IRepositorioPlato contextPlato
            , IUnitOfWork unitOfWork, IAgregarPlatoToMenuOutputPort outputPort) => 
            (ContextMenu, ContextPlato, UnitOfWork, OutputPort) = 
            (contextMenu, contextPlato, unitOfWork, outputPort);
       
        public async Task Handle(int? idMenu, int? IdPlato)
        {
            var Menu = ContextMenu.GetMenu(idMenu);
            var Plato = ContextPlato.GetPlato(IdPlato);

            PlatoMenu platoMenu = new PlatoMenu();
            platoMenu.MenuId = Menu.IdMenu;
            platoMenu.PlatoId = Plato.IdPlato;
            platoMenu.Menu = Menu;
            platoMenu.Plato = Plato;
            if (Menu.PlatoMenu == null)
            {
                Menu.PlatoMenu = new List<PlatoMenu>();

                Menu.PlatoMenu.Add(platoMenu);
            }
            else
            {
                Menu.PlatoMenu.Append(platoMenu);
            }
           
           
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle( new()
            {
                IdMenu = (int)idMenu,
                IdPlato = (int)IdPlato

            });
           
        }
    }
}
