using Mipalzoleta.RepositorioEFcore.DataContext;
using MiPlazoleta.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.RepositorioEFcore.Repositorios
{
    public class UnitOfWork : IUnitOfWork
    {

        readonly MiplazoletaDbContext Context;
        public UnitOfWork(MiplazoletaDbContext context) => Context = context;
        public Task<int> SaveChanges()
        {
           return Context.SaveChangesAsync();
        }
    }
}
