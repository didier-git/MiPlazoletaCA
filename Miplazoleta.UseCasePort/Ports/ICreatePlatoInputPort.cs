using MiPlazoleta.DTOs.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.UseCasePort.Ports
{
    public interface ICreatePlatoInputPort
    {
        Task Handle(CrearPlatoDTO Plato);
    }
}
