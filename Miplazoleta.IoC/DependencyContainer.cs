using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiPlazoleta.Presenters;
using MiPlazoleta.RepositorioEFcore;
using MiPlazoleta.UseCases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPlazoleta.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddMiplazoletaDependencies(
            this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddRepositories(Configuration);
            services.AddPresenterServices();
            services.AddUsecasesServices();
            return services;
        }
    }
}
