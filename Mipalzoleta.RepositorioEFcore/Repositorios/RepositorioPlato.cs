using Microsoft.Extensions.DependencyInjection;
using Mipalzoleta.RepositorioEFcore.DataContext;
using MiPlazoleta.Entities.Interfaces;
using MiPlazoleta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.RepositorioEFcore.Repositorios
{
    public class RepositorioPlato : IRepositorioPlato
    {
        readonly MiplazoletaDbContext context;
        //public readonly IServiceProvider ServiceProvider;
        //public RepositorioPlato(IServiceProvider serviceProvider)=>ServiceProvider=serviceProvider;

       public RepositorioPlato(MiplazoletaDbContext Context) => context = Context;
        public void Crear(Plato Plato)
        {
            //using IServiceScope scope = ServiceProvider.CreateScope();  
            //IServiceProvider serviceProvider = scope.ServiceProvider;   
            //var context = serviceProvider.GetRequiredService<MiplazoletaDbContext>();
            context.Add(Plato);
        }

        public IEnumerable<Plato> GetAll()
        {
            //using IServiceScope scope = ServiceProvider.CreateScope();
            //IServiceProvider serviceProvider = scope.ServiceProvider;
            //var context = serviceProvider.GetRequiredService<MiplazoletaDbContext>();
            return context.Platos.ToList();
        }

        public Plato GetPlato(int? id)
        {

            return context.Platos.Find(id);   
        }
    }
}
