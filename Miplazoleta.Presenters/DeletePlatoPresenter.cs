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
    public class DeletePlatoPresenter : IPresenter<PlatoDTO>, IDeletePlatoOutputPort
    {
        public PlatoDTO Content { get; private set; }

        public Task Handle(PlatoDTO nombrePlato)
        {
            Content = nombrePlato;  
            return Task.CompletedTask;   
        }
    }
}
