
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Mipalzoleta.RepositorioEFcore.DataContext;
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
    public class CreatePlatoController 
    {
        readonly ICreatePlatoInputPort InputPort;
        readonly ICreatePlatoOutputPort OutputPort;
        //public readonly IServiceProvider ServiceProvider;
        public CreatePlatoController(
            ICreatePlatoInputPort inputPort, ICreatePlatoOutputPort outputPort) =>
            (InputPort, OutputPort) = (inputPort, outputPort);
        //public CreatePlatoController(IServiceProvider serviceProvider) => ServiceProvider = serviceProvider;
        
        [HttpPost]
        public async Task<PlatoDTO> CrearPlato(CrearPlatoDTO plato)
        {

            await InputPort.Handle(plato);
            return ((IPresenter<PlatoDTO>)OutputPort).Content;
            
        }
        
    }
}
