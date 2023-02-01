using BLL;
using DAL;
using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using Http.API;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var startup = new Startup(builder.Configuration);

        startup.ConfigureServices(builder.Services);

        builder.WebHost.UseIISIntegration();

        // DI stuff
        var container = new Container(r => r.With(propertiesAndFields: req => req.ServiceType.Name.EndsWith("Controller") ? PropertiesAndFields.Properties()(req) : null));
        container.RegisterServices();

        var factory = new DryIocServiceProviderFactory(container);

        builder.Host.UseServiceProviderFactory(new DryIocServiceProviderFactory(container));
        builder.Host.UseContentRoot(Directory.GetCurrentDirectory());

        var app = builder.Build();

        app.MapControllers();

        startup.Configure(app);

        app.Run();
    }
}