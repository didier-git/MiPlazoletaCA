using Microsoft.Extensions.DependencyInjection;
using Mipalzoleta.RepositorioEFcore.DataContext;
using MiPlazoleta.DTOs.DTOs;
using MiPlazoleta.Entities.Interfaces;
using MiPlazoleta.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.RepositorioEFcore.Repositorios
{
    public class RepositorioMenu : IRepositorioMenu 
    {
        readonly MiplazoletaDbContext context;
        //public readonly IServiceProvider ProviderServices;
        public RepositorioMenu(MiplazoletaDbContext Context) => context = Context;

        //public RepositorioMenu(IServiceProvider serviceProvider) => ProviderServices = serviceProvider;

        
        public void CrearMenu(Menu menu)
        {
            //using IServiceScope scope = ProviderServices.CreateScope();
            //IServiceProvider serviceProvider = scope.ServiceProvider;
            //var context = serviceProvider.GetRequiredService<MiplazoletaDbContext>();
            
            context.Add(menu);
        }

        public IEnumerable<Menu> GetMenus()
        {

            //using IServiceScope scope = ProviderServices.CreateScope();
            //IServiceProvider serviceProvider = scope.ServiceProvider;
            //var context = serviceProvider.GetRequiredService<MiplazoletaDbContext>();
            return context.Menus.ToList();
        }

        public Menu GetMenu(int? id)
        {

            return context.Menus.Find(id);
        }
    }
}
