using DAL;
using Microsoft.OpenApi.Models;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using DAL.Context;

namespace Http.API
{
    public static class Startup
    {       
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddMvc();
            services.AddCors();
            services.AddControllers();
            services.AddLogging();

            services.AddSwaggerGen(o =>
            {
                o.SwaggerDoc($"v{Assembly.GetExecutingAssembly().GetName().Version.Major}", new OpenApiInfo
                {
                    Title = "API Secret Santa Generator",
                    Version = $"v{Assembly.GetExecutingAssembly().GetName().Version.Major}",
                    Description = "Secret Santa API generator",
                    Contact = new OpenApiContact
                    {
                        Name = "Tatiana Kravchenko",
                        Email = "kravchenkodevelop@gmail.com",
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT License"
                    }
                });
                o.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml"));

                o.ResolveConflictingActions(apidescription => apidescription.First());
                o.IgnoreObsoleteActions();
                o.IgnoreObsoleteProperties();
                o.CustomSchemaIds(t => t.FullName);
            });
            

            services.AddEndpointsApiExplorer();
        }

        public static  void ConfigureApp(this IApplicationBuilder app)
        {
#if DEBUG||MYTESTS 
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
#endif

            app.UseSwagger(o =>
            {
                o.RouteTemplate = "api-docs/{documentName}/swagger.json";
                o.SerializeAsV2 = true;
            });
            app.UseSwaggerUI(o =>
            {
                o.DocumentTitle = "Secret Santa Generator API";
                o.RoutePrefix = "api-docs";
                o.SwaggerEndpoint("../api-docs/v1/swagger.json", $"API Secret Santa Generator v1");
            });


            app.UseStatusCodePages();
            app.UseDefaultFiles(); app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

        }
    }
}
