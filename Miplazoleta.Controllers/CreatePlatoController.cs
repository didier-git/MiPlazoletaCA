
using Microsoft.AspNetCore.Mvc;
using Mipalzoleta.RepositorioEFcore.DataContext;
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
    public class CreatePlatoController 
    {
        readonly ICreatePlatoInputPort InputPort;
        readonly ICreatePlatoOutputPort OutputPort;
        public CreatePlatoController(
            ICreatePlatoInputPort inputPort, ICreatePlatoOutputPort outputPort) => 
            (InputPort,OutputPort) = (inputPort,outputPort);  
        [HttpPost]
        public async Task<PlatoDTO> CrearPlato(CrearPlatoDTO plato)
        {
            await InputPort.Handle(plato);
            return ((IPresenter<PlatoDTO>)OutputPort).Content;
        }
        
    }
}
