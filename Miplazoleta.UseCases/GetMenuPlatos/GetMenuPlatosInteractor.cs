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

namespace Miplazoleta.UseCases.GetMenuPlatos
{
    public class GetMenuPlatosInteractor : IGetMenuPlatosInputPort
    {

        public readonly IRepositorioPlatoMenu ContextPlatoMenu;
        public readonly IRepositorioMenu ContextMenu;
        public readonly IRepositorioPlato ContextPlato;
        public readonly IGetMenuPlatosOutputPort OutputPort;

        public GetMenuPlatosInteractor
            (IRepositorioPlatoMenu contextPlatoMenu, IRepositorioMenu contextMenu, IRepositorioPlato contextPlato, IGetMenuPlatosOutputPort outputPort) 
            => (ContextPlatoMenu, ContextMenu, ContextPlato,OutputPort) = (contextPlatoMenu, contextMenu, contextPlato,outputPort);
        
        public async Task Handle(int? idMenu)
        {
            var menu = ContextMenu.GetMenu(idMenu);

            PlatoMenuGetDto MenuPlato = new()
            {
                idMenu = menu.IdMenu,
                NombreMenu = menu.Nombre
            };

            MenuPlato.Platos = new List<PlatoDTO>();    

            if (menu.PlatoMenu != null) {

                foreach (var elemento in menu.PlatoMenu)
                {
                    var plato = ContextPlato.GetPlato(elemento.PlatoId);

                    var platoDTO = new PlatoDTO
                    {
                        Id = plato.IdPlato,
                        Nombre = plato.Nombre,
                        Descripcion = plato.Descripcion,
                        Precio = plato.precio
                    };

                    MenuPlato.Platos.Add(platoDTO); 
                }
               
            }

            await OutputPort.Handle(MenuPlato);
     
        }
    }
}
