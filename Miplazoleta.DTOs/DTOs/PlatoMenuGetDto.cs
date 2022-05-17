using MiPlazoleta.DTOs.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.DTOs.DTOs
{
    public class PlatoMenuGetDto
    {
        public int idMenu { get; set; }
        public string NombreMenu { get; set; }  

        public ICollection<PlatoDTO> Platos { get; set; }
    }
}
