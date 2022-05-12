using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Miplazoleta.DTOs.DTOs;
using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.Entities.POCOs;
using MiPlazoleta.Presenters;
using MiPlazoleta.UseCasePort.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class CrearMenuController
    {
        public readonly ICrearMenuInputPort InputPort;
        public readonly ICrearMenuOutputPort OutputPort;
        //public readonly IServiceProvider ServiceProvider;

        public CrearMenuController(
            ICrearMenuInputPort inputPort, ICrearMenuOutputPort outputPort)
            => (InputPort, OutputPort) = (inputPort, outputPort);
        //public CrearMenuController(IServiceProvider serviceProvider)=>ServiceProvider = serviceProvider;   

        [HttpPost]
        public async Task<MenuDTO> CrearMenu(CrearMenuDTO menu)
        {
            //using IServiceScope scope = ServiceProvider.CreateScope();  
            //IServiceProvider serviceProvider = scope.ServiceProvider; 
            //var InputPort = serviceProvider.GetRequiredService<ICrearMenuInputPort>();  
            //var OutputPort = serviceProvider.GetRequiredService<ICrearMenuOutputPort>();
            
            await InputPort.Handle(menu);
            return ((IPresenter<MenuDTO>)OutputPort).Content;

        }

    }
}
