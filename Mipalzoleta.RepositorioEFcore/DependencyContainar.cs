using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mipalzoleta.RepositorioEFcore.DataContext;
using Miplazoleta.RepositorioEFcore.Repositorios;
using MiPlazoleta.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.RepositorioEFcore
{
    public static class DependencyContainar 
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration Configuration )  
        {
            //var options = new DbContextOptionsBuilder<MiplazoletaDbContext>();
            
            services.AddDbContext<MiplazoletaDbContext>(options => 
            options.UseMySql(Configuration.GetConnectionString("miplazoletadb"),
            ServerVersion.Parse("10.1.38"),null));
           
            services.AddScoped<IRepositorioPlato, RepositorioPlato>();
            services.AddScoped<IUnitOfWork,UnitOfWork>();
            return services;

        }
    }
}
