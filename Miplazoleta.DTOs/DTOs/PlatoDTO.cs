using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.DTOs.DTOs
{
    public class PlatoDTO
    {
        public int Id { get; init; }
        public string Nombre { get; init; }
        public string Descripcion { get; init; }
        public Decimal Precio { get; init; }
    }
}
