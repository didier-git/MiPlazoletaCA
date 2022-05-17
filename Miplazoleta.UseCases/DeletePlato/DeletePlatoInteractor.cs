using Miplazoleta.UseCasePort.Ports;
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
        
        public Task Handle(int? platoId)
        {
            var Plato = RepositorioPlato.GetPlato(platoId);

            RepositorioPlato.DeletePlato(Plato);
            OutputPort.Handle(new()
            {
                Id = Plato.IdPlato,
                Nombre = Plato.Nombre,
                Descripcion = Plato.Descripcion,
                Precio = Plato.precio

            });
            UnitOfWork.SaveChanges();
            return Task.CompletedTask;   


        }
    }
}
