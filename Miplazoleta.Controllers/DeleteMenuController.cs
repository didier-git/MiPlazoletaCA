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
    public class DeleteMenuController
    {
        public readonly IDeleteMenuInputPort InputPort;
        public readonly IDeleteMenuOutputPort OutputPort;

        public DeleteMenuController(IDeleteMenuInputPort inputPort, IDeleteMenuOutputPort outputPort)
        {
            InputPort = inputPort;
            OutputPort = outputPort;
        }

        [HttpDelete]
        public async Task<MenuDTO> DeleteMenu(int? IdMenu)
        {
            await InputPort.Handle(IdMenu);
            return ((IPresenter<MenuDTO>)OutputPort).Content;
        }
    }
}
