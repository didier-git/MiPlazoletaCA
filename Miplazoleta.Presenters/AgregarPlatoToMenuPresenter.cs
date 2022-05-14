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
    public class AgregarPlatoToMenuPresenter : IAgregarPlatoToMenuOutputPort, IPresenter<PlatoMenuAddDto>

    {
        public PlatoMenuAddDto Content { get; private set; }

        public Task Handle(PlatoMenuAddDto PlatoMenu)
        {
            Content = PlatoMenu;    
            return Task.CompletedTask;  
        }
    }
}
