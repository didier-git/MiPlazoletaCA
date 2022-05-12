using Microsoft.Extensions.DependencyInjection;
using Mipalzoleta.RepositorioEFcore.DataContext;
using MiPlazoleta.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.RepositorioEFcore.Repositorios
{
    public class UnitOfWork : IUnitOfWork
    {

        readonly MiplazoletaDbContext Context;
        //public readonly IServiceProvider ServiceProvider;
        public UnitOfWork(MiplazoletaDbContext context) => Context = context;
        //public UnitOfWork(IServiceProvider serviceProvider)=>ServiceProvider = serviceProvider; 
        public Task<int> SaveChanges()
        {
            //using IServiceScope scope = ServiceProvider.CreateScope();
            //IServiceProvider serviceProvider = scope.ServiceProvider; 
            //var context = serviceProvider.GetRequiredService<MiplazoletaDbContext>();   
           return Context.SaveChangesAsync();
        }
    }
}
