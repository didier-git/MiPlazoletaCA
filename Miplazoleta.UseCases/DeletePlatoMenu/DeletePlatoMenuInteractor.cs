using Miplazoleta.DTOs.DTOs;
using Miplazoleta.UseCasePort.Ports;
using MiPlazoleta.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.UseCases.DeletePlatoMenu
{
    public class DeletePlatoMenuInteractor : IDeletePlatoMenuInputPort
    {
        public readonly IDeletePlatoMenuOutpuPort OutputPort;
        public readonly IRepositorioPlatoMenu Repositorio;
        public readonly IUnitOfWork UnitOfWork;

        public DeletePlatoMenuInteractor
            (IDeletePlatoMenuOutpuPort outputPort, IRepositorioPlatoMenu repositorio, IUnitOfWork unitOfWork)
        {
            OutputPort = outputPort;
            Repositorio = repositorio;
            UnitOfWork = unitOfWork;
        }

            public async Task Handle(int? idPlato)
        {
            var platoMenu = Repositorio.GetPlatoMenu(idPlato);
            PlatoMenuDto PlatoMenu = new()
            {
                IdPlato = platoMenu.PlatoId,
                IdMenu = platoMenu.MenuId
            };

            await Repositorio.DeletePlatoMenu(platoMenu);
            await UnitOfWork.SaveChanges();
            await OutputPort.Handle(PlatoMenu);

        }
    }
}
