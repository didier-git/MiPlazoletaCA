using Miplazoleta.DTOs.DTOs;
using MiPlazoleta.DTOs.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.UseCasePort.Ports
{
    public  interface IAgregarPlatoToMenuOutputPort
    {
        Task Handle(PlatoMenuAddDto PlatoMenu);
    }
}
