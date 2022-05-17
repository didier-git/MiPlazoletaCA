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
    public class AgregarPlatoToMenuController
    {
        public readonly IAddPlatoToMenuInputPort InputPort;
        public readonly IAgregarPlatoToMenuOutputPort OutputPort;

        public AgregarPlatoToMenuController(IAddPlatoToMenuInputPort inputPort,
            IAgregarPlatoToMenuOutputPort outputPort)
            => (InputPort, OutputPort) = (inputPort, outputPort);

        [HttpPost]
        public async Task<PlatoMenuAddDto> AgregarPlatoToMenu(int IdMenu , int IdPlato)
        {
            await InputPort.Handle(IdMenu,IdPlato);
            return ((IPresenter<PlatoMenuAddDto>)OutputPort).Content;
        }
        

    }
}
