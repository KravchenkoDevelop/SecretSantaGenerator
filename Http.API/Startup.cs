using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Http.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddControllers();
            services.AddSwaggerGen(o =>
            {
                o.SwaggerDoc($"{Assembly.GetExecutingAssembly().GetName().Name}", new OpenApiInfo
                {
                    Title = "API Secret Santa Generator",
                    Version = $"{Assembly.GetExecutingAssembly().GetName().Version.Major}",
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
            services.AddCors();

            services.AddEndpointsApiExplorer();
        }

        public void Configure(IApplicationBuilder app)
        {
#if DEBUG
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
#endif
            app.UseSwagger(o =>
            {
                o.RouteTemplate = "api-docs/swagger.json";
                o.SerializeAsV2 = true;
            });
            app.UseSwaggerUI(o =>
            {
                o.SwaggerEndpoint($"v{Assembly.GetExecutingAssembly().GetName().Version.Major}/swagger.json", $"API Secret Santa Generator v{Assembly.GetExecutingAssembly().GetName().Version.Major}");
                o.RoutePrefix = "api-docs";
            });

            //app.UseSwagger(options =>
            //{
            //    options.SerializeAsV2 = true;
            //});
            //app.UseSwaggerUI(options =>
            //{
            //    options.SwaggerEndpoint("../swagger/v1/swagger.json", "v1");
            //    options.RoutePrefix = string.Empty;
            //});

            app.UseStatusCodePages();
            app.UseDefaultFiles(); app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(e =>
            {
                e.MapControllers();
            });

        }

        public string SomeString()
        {
            return "some message";
        }


    }
}
