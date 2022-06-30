using MiPlazoleta.DTOs.DTOs;
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
        void CrearMenu(Menu menu);
        IEnumerable<Menu> GetMenus();

        Menu GetMenu(int? id);
        bool DeleteMenu(Menu menu);
        Menu GetMenuPlatos(int? id);    


    }
}
