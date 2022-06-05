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
    public class DeletePlatoMenuController
    {
        public readonly IDeletePlatoMenuInputPort InputPort;
        public readonly IDeletePlatoMenuOutpuPort OutpuPort;

        public DeletePlatoMenuController
            (IDeletePlatoMenuInputPort inputPort, IDeletePlatoMenuOutpuPort outpuPort)
        {
            InputPort = inputPort;
            OutpuPort = outpuPort;
        }

        [HttpDelete]

        public async Task<PlatoMenuDto> DeletePlatoMenu(int? id)
        {
            await InputPort.Handle(id);
            return ((IPresenter<PlatoMenuDto>)OutpuPort).Content;
        }
    }
}
