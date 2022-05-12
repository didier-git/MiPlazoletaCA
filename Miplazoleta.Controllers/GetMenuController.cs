﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
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
    public class GetMenuController
    {

        readonly IGetMenuInputPort InputPort;
        readonly IGetMenuOutputPort OutputPort;
        //public readonly IServiceProvider ServiceProvider;

        public GetMenuController(
            IGetMenuInputPort inputPort, IGetMenuOutputPort outputPort)
            => (InputPort, OutputPort) = (inputPort, outputPort);
        //public GetMenuController(IServiceProvider serviceProvider)=>ServiceProvider = serviceProvider;  

        [HttpGet]
        public async Task <IEnumerable<MenuDTO>> GetMenus()
        {
            //using IServiceScope scope = ServiceProvider.CreateScope();  
            //IServiceProvider serviceProvider = scope.ServiceProvider; 
            //var InputPort = ServiceProvider.GetRequiredService<IGetMenuInputPort>();
            //var OutputPort = ServiceProvider.GetRequiredService<IGetMenuOutputPort>();  
           
            await InputPort.Handle();
            return ((IPresenter<IEnumerable<MenuDTO>>)OutputPort).Content;
        }
    }
}
