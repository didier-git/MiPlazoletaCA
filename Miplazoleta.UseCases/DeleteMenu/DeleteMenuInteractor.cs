using Miplazoleta.UseCasePort.Ports;
using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.UseCases.DeleteMenu
{
    public class DeleteMenuInteractor : IDeleteMenuInputPort
    {
        public readonly IRepositorioMenu Repositorio;
        public readonly IUnitOfWork UnitOfWork;
        public readonly IDeleteMenuOutputPort OutputPort;

        public DeleteMenuInteractor(IRepositorioMenu repositorio, IUnitOfWork unitOfWork, IDeleteMenuOutputPort outputPort)
        {
            Repositorio = repositorio;
            UnitOfWork = unitOfWork;
            OutputPort = outputPort;
        }

        public async Task Handle(int? IdMenu)
        {
            var menu = Repositorio.GetMenu(IdMenu);
            MenuDTO Menu = new()
            {
                Id = menu.IdMenu,
                Nombre = menu.Nombre,
                Descripcion = menu.Descripcion

            };
            await OutputPort.Handle(Menu);
            await Repositorio.DeleteMenu(menu);
            await UnitOfWork.SaveChanges();
        }
    }
}
