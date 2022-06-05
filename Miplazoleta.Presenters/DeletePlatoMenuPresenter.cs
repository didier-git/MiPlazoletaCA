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
    public class DeletePlatoMenuPresenter : IPresenter<PlatoMenuDto>, IDeletePlatoMenuOutpuPort
    {
        public PlatoMenuDto Content { get; private set; }

        public Task Handle(PlatoMenuDto platoMenu)
        {
            Content = platoMenu;
            return Task.CompletedTask;
        }
    }
}
