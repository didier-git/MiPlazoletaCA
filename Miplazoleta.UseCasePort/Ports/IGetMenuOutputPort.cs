using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.UseCasePort.Ports
{
    public interface IGetMenuOutputPort
    {
        Task Handle(IEnumerable<MenuDTO> Menus);
    }
}
