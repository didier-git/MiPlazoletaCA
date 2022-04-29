using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.Entities.POCOs
{
     public class Menu
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual IEnumerable<Plato> platos { get; set; }



    }
}
