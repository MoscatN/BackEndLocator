using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LocatorBackEnd;
using LocatorBackEnd.Data;
using RestSharp;
using System.Net.Http;
using System.Net;
using System.Reflection;
using Microsoft.OpenApi.Models;

namespace LocatorBackEnd
{
    public class Startup
    {
        private readonly string _MyCors = "MyCors"; 

        public Startup(IConfiguration configuration) 
        {
            Configuration = configuration; 
        }    

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //Agregando nuevas politicas
            
        }

        //Si no funciona cambiar el origen de IHostingEnvironment
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(); 
            }

            app.UseCors(_MyCors); 
        }
    }
}