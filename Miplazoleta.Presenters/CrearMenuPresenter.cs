using Miplazoleta.DTOs.DTOs;
using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.Entities.POCOs;
using MiPlazoleta.UseCasePort.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.Presenters
{
    public class CrearMenuPresenter : IPresenter<MenuDTO> , ICrearMenuOutputPort
    {
        public MenuDTO Content { get; private set; }

        public Task Handle(MenuDTO Menu)
        {
            Content = Menu;
            return Task.CompletedTask;
        }
    }
}
