using Miplazoleta.DTOs.DTOs;
using Miplazoleta.RepositorioEFcore.Repositorios;
using Miplazoleta.UseCasePort.Ports;
using MiPlazoleta.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.UseCases.GetPlatos
{
    public class GetPlatosInteractor : IGetPlatosInputPort
    {

        IRepositorioPlato Repositorio;
        IGetPlatosOutputPort OutputPort;

        public GetPlatosInteractor(IRepositorioPlato repositorio, IGetPlatosOutputPort outputPort) => (Repositorio, OutputPort) = (repositorio, outputPort);
        public  Task Handle()
        {
            var platos = Repositorio.GetAll().Select(p => new PlatoDTO
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Descripcion = p.Descripcion,
                Precio = p.precio


            });

            OutputPort.Handler(platos);
            return Task.CompletedTask;
        }
    }
}
