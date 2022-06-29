using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.Entities.POCOs
{
    public class PlatoMenu
    {
        public int PlatoId { get; set; }
        public Plato Plato { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }


    }
}
