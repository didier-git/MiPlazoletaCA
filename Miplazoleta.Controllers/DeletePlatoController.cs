using Microsoft.AspNetCore.Mvc;
using Miplazoleta.UseCasePort.Ports;
using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.Controllers
{
    [Route("Api/[controller]")]
    [ApiController] 
    public class DeletePlatoController
    {
        public  readonly IDeletePlatoInputPort InputPort;
        public readonly IDeletePlatoOutputPort OutputPort;

        public DeletePlatoController
            (IDeletePlatoInputPort inputPort, IDeletePlatoOutputPort outputPort)
            => (InputPort, OutputPort) = (inputPort, outputPort);
        
        [HttpDelete]
        public async Task<PlatoDTO> DeletePlato(int? id)
        {
            await InputPort.Handle(id);
            return ((IPresenter<PlatoDTO>)OutputPort).Content;
        }

    }
}
