using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WebApplicationDemo.Filter;

namespace WebApplicationDemo
{
    public class Program
    {

        public IHostingEnvironment HostingEnvironment { get; }
        public IConfiguration Configuration { get; }

        // Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(GlobalActionFilter)); // by type
            });

            if (HostingEnvironment.IsDevelopment())
            {
                // Development configuration
            }
            else
            {
                // Staging/Production configuration
            }

            // Configuration is available during startup. Examples:
            // Configuration["key"]
            // Configuration["subsection:suboption1"]

        }

        // Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {

        }


        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
