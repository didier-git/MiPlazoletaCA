using Miplazoleta.DTOs.DTOs;
using Miplazoleta.UseCasePort.Ports;
using MiPlazoleta.Entities.Interfaces;
using MiPlazoleta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.UseCases.CrearPlato
{
    public class CrearPlatoInteractor : ICreatePlatoInputPort
    {
        readonly IRepositorioPlato Repositorio;
        readonly IUnitOfWork UnitOfWork;
        readonly ICreatePlatoOutputPort OutputPort;

        public CrearPlatoInteractor(
            IRepositorioPlato repositorio, IUnitOfWork unitOfWork, ICreatePlatoOutputPort outputPort)
            => (Repositorio, UnitOfWork, OutputPort) = (repositorio, unitOfWork, outputPort);


        public async Task Handle(CrearPlatoDTO plato)
        {
            Plato NewPlato = new Plato { 
            
                Nombre = plato.Nombre,
                Descripcion = plato.Descripcion,
                precio = plato.precio
            
            };

            Repositorio.Crear(NewPlato);
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle(new PlatoDTO
            {
                Id = NewPlato.Id,
                Nombre = NewPlato.Nombre,
                Descripcion = NewPlato.Descripcion,
                Precio = NewPlato.precio

            });
        }
    }
}
