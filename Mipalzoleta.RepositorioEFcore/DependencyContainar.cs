using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mipalzoleta.RepositorioEFcore.DataContext;
using MiPlazoleta.RepositorioEFcore.Repositorios;
using MiPlazoleta.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.RepositorioEFcore
{
    public static class DependencyContainar 
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration Configuration)  
        {
         
            
            services.AddDbContext<MiplazoletaDbContext>(options => 
            options.UseMySql(Configuration.GetConnectionString("miplazoletadb"),
            ServerVersion.Parse("10.1.38"),null));
           
            services.AddTransient<IRepositorioPlato, RepositorioPlato>();
            services.AddTransient<IRepositorioMenu, RepositorioMenu>();
            services.AddTransient<IUnitOfWork,UnitOfWork>();
            
            return services;

        }
    }
}
