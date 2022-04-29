using Miplazoleta.DTOs.DTOs;
using MiPlazoleta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.Entities.Interfaces
{
    public interface IRepositorioMenu
    {
        void CrearMenu(CrearMenuDTO menu);
        IEnumerable<Menu> GetMenus();
    }
}
