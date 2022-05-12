using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.Entities.POCOs;
using MiPlazoleta.Presenters;
using MiPlazoleta.UseCasePort.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.Presenters
{
    public class GetMenuPresenter : IPresenter<IEnumerable<MenuDTO>> , IGetMenuOutputPort
    {

        public IEnumerable<MenuDTO> Content { get; private set; }

        public Task Handle(IEnumerable<MenuDTO> Menus)
        {
            Content = Menus;

            return Task.CompletedTask;  
        }
    }
}
