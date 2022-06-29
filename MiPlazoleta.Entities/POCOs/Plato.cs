using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.Entities.POCOs
{
     public class Plato
    {
        public int IdPlato { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Decimal precio { get; set; }
        public virtual List<PlatoMenu> PlatoMenu { get; set; }


    }
}
