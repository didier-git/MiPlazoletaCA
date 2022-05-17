using Miplazoleta.DTOs.DTOs;
using Miplazoleta.UseCasePort.Ports;
using MiPlazoleta.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.Presenters
{
    public class GetMenuPlatosPresenter : IPresenter<PlatoMenuGetDto>, IGetMenuPlatosOutputPort
    {
        public PlatoMenuGetDto Content { get; private set; }

        public Task Handle(PlatoMenuGetDto menu)
        {
            Content = menu;
            return Task.CompletedTask;  
        }
    }
}
