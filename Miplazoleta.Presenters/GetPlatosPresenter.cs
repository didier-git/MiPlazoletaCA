using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.UseCasePort.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.Presenters
{
    public class GetPlatosPresenter : IGetPlatosOutputPort , IPresenter<IEnumerable<PlatoDTO>>
    {

        public IEnumerable<PlatoDTO> Content { get; private set; }

        public Task Handler(IEnumerable<PlatoDTO> Platos)
        {
            Content = Platos;
            return Task.CompletedTask;
        }
    }
}
