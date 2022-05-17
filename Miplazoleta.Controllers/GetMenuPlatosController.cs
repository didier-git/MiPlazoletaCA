using Microsoft.AspNetCore.Mvc;
using Miplazoleta.DTOs.DTOs;
using Miplazoleta.UseCasePort.Ports;
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
    public  class GetMenuPlatosController 
    {

        public readonly IGetMenuPlatosInputPort InputPort;
        public readonly IGetMenuPlatosOutputPort OutputPort;

        public GetMenuPlatosController(IGetMenuPlatosInputPort inputPort, IGetMenuPlatosOutputPort outputPort)
            => (InputPort, OutputPort) = (inputPort, outputPort);
        
        
        [HttpGet]
        public async Task<PlatoMenuGetDto> GetMenuPlatos(int? idMenu)
        {
            await InputPort.Handle(idMenu);

            return ((IPresenter<PlatoMenuGetDto>)OutputPort).Content;
        }



    }
}
