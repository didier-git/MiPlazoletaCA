using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Miplazoleta.Presenters;
using Miplazoleta.RepositorioEFcore;
using Miplazoleta.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miplazoleta.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddMiplazoletaDependencies(
            this IServiceCollection services, IConfiguration Configuration )
        {
            services.AddRepositories(Configuration);
            services.AddPresenterServices();
            services.AddUsecasesServices();
            return services;
        }
    }
}
