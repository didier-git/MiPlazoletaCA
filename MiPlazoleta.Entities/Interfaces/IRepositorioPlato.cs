using MiPlazoleta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.Entities.Interfaces
{
    public interface IRepositorioPlato
    {
        void Crear(Plato plato);
        IEnumerable<Plato> GetAll();
        Plato GetPlato(int? id);
        void DeletePlato(Plato plato);  
    }
}
