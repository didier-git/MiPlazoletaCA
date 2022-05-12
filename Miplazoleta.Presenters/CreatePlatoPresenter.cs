using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.UseCasePort.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.Presenters
{
    public class CreatePlatoPresenter : IPresenter<PlatoDTO>, ICreatePlatoOutputPort
    {
        public PlatoDTO Content { get; private set; }

        public Task Handle(PlatoDTO Plato)
        {
            Content = Plato;

            return Task.CompletedTask;
        }
    }
}
