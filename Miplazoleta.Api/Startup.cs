using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Miplazoleta.UseCases;
using MiPlazoleta.IoC;
using MiPlazoleta.UseCasePort.Ports;
using MiPlazoleta.UseCases.CrearMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiPlazoleta.Api
{
    public class Startup
    {
        private readonly string Mycors = "MyCors";
         
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
        

            
            services.AddControllers();
            
            services.AddMvcCore(); 
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Miplazoleta.Api", Version = "v1" });
            });

            services.AddCors(options => options.AddPolicy(Mycors,builder => {

                builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
            
            }));

            services.AddMiplazoletaDependencies(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Miplazoleta.Api v1"));
            }
             

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors(Mycors);

            app.UseAuthorization();

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
