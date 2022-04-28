using Miplazoleta.DTOs.DTOs;
using Miplazoleta.UseCasePort.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.Presenters
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
