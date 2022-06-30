using Miplazoleta.UseCasePort.Ports;
using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.UseCases.DeletePlato
{
    public class DeletePlatoInteractor : IDeletePlatoInputPort
    {
        public readonly IRepositorioPlato RepositorioPlato;
        public readonly IUnitOfWork UnitOfWork;
        public readonly IDeletePlatoOutputPort OutputPort;  

        public DeletePlatoInteractor(IRepositorioPlato repositorioPlato, IUnitOfWork unitOfWork, IDeletePlatoOutputPort outputPort) 
            =>(RepositorioPlato, UnitOfWork, OutputPort) 
            =(repositorioPlato, unitOfWork, outputPort);
        
        public async Task Handle(int? platoId)
        {
            var Plato = RepositorioPlato.GetPlato(platoId);

            PlatoDTO platoDto = new()
            {
                Id = Plato.IdPlato,
                Nombre = Plato.Nombre,
                Descripcion = Plato.Descripcion,
                Precio = Plato.precio

            };

            RepositorioPlato.DeletePlato(Plato);
            await OutputPort.Handle(platoDto);
            await UnitOfWork.SaveChanges();
              


        }
    }
}
