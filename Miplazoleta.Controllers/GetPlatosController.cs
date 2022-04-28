using Microsoft.AspNetCore.Mvc;
using Miplazoleta.DTOs.DTOs;
using Miplazoleta.Presenters;
using Miplazoleta.UseCasePort.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class GetPlatosController
    {
        readonly IGetPlatosInputPort InputPort;
        readonly IGetPlatosOutputPort OutputPort;

        public GetPlatosController(
            IGetPlatosInputPort inputPort, IGetPlatosOutputPort outputPort) 
            => (InputPort, OutputPort) = (inputPort, outputPort);
        [HttpGet]
        public async Task<IEnumerable<PlatoDTO>> GetPlatos()
        {
            await InputPort.Handle();
            return ((IPresenter<IEnumerable<PlatoDTO>>)OutputPort).Content;
            
        }
    }
}
