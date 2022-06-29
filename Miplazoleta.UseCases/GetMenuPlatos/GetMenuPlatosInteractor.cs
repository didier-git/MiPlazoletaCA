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


        public readonly IRepositorioMenu ContextMenu;
        public readonly IRepositorioPlato ContextPlato;
        public readonly IGetMenuPlatosOutputPort OutputPort;

        public GetMenuPlatosInteractor
            ( IRepositorioMenu contextMenu, IRepositorioPlato contextPlato, IGetMenuPlatosOutputPort outputPort) 
            => (ContextMenu, ContextPlato,OutputPort) = (contextMenu, contextPlato,outputPort);
        
        public async Task Handle(int? idMenu)
        {
            var menu = ContextMenu.GetMenu(idMenu);

            PlatoMenuGetDto MenuPlato = new()
            {
                idMenu = menu.IdMenu,
                NombreMenu = menu.Nombre
            };

            if (menu.PlatoMenu== null)
            {
                await OutputPort.Handle(MenuPlato); 
            }
            else
            {
                MenuPlato.Platos = new List<PlatoDTO>();
                foreach (var elemento in menu.PlatoMenu)
                {
                    var plato = ContextPlato.GetPlato(elemento.PlatoId);
                    //var plato = elemento.Plato;

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
