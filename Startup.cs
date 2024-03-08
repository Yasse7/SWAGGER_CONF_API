using Microsoft.Win32;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace SWAGGER_CONFIG_API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }


        //To retrieve the Configuration settings 
        public Startup(IConfiguration configuration)
        {
            //to inject configuration into the class
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //registers a single instance of the service for the entire lifetime of the application
            services.AddSingleton(Configuration);

            services.AddControllers();
            //dds Swagger generation services
            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //it enables the developer exception page and configures Swagger.
            if (env.IsDevelopment())//if it runs
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();//for exploring the API documentation
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();//it maps controllers to handle incoming requests.
            });
        }
    }
}
