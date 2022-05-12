using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.Presenters;
using MiPlazoleta.UseCasePort.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class GetPlatosController
    {
        readonly IGetPlatosInputPort InputPort;
        readonly IGetPlatosOutputPort OutputPort;
        //public readonly IServiceProvider ServiceProvider;

        public GetPlatosController(
            IGetPlatosInputPort inputPort, IGetPlatosOutputPort outputPort)
            => (InputPort, OutputPort) = (inputPort, outputPort);
        //public GetPlatosController(IServiceProvider serviceProvider)=>ServiceProvider = serviceProvider;    
        
        [HttpGet]
        public async Task<IEnumerable<PlatoDTO>> GetPlatos()
        {
            //using IServiceScope scope = ServiceProvider.CreateScope();  
            //IServiceProvider serviceProvider = scope.ServiceProvider;
            //var InputPort = serviceProvider.GetRequiredService<IGetPlatosInputPort>(); 
            //var OutputPort  = serviceProvider.GetRequiredService<IGetPlatosOutputPort>();
            
            await InputPort.Handle();
            return ((IPresenter<IEnumerable<PlatoDTO>>)OutputPort).Content;
            
        }
    }
}
