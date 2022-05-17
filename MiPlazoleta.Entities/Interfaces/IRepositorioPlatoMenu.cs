using MiPlazoleta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.Entities.Interfaces
{
    public interface IRepositorioPlatoMenu
    {
        PlatoMenu GetPlatoMenu(int? id);

        void AddPlatoMenu(PlatoMenu menu);
        
        ICollection<PlatoMenu> GetPlatoMenuList(int? id);    

    }
}
