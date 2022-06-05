using Miplazoleta.UseCasePort.Ports;
using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.Presenters
{
    public class DeleteMenuPresenter : IPresenter<MenuDTO>, IDeleteMenuOutputPort
    {
        public MenuDTO Content { get; private set; }

        public Task Handle(MenuDTO Menu)
        {
            Content = Menu;
            return Task.CompletedTask;
        }
    }
}
