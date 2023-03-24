using BLL;
using Http.API;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        //config application properties
        builder.Services.ConfigureServices();
        //config DI container
        builder.Services.RegisterServices();
        //config DB 
        builder.Services.RegiserDB();

        builder.WebHost.UseIISIntegration();

        builder.Host.UseContentRoot(Directory.GetCurrentDirectory());

        var app = builder.Build();

        app.MapControllers();
        //configure app runtime
        app.ConfigureApp();

        app.Run();
    }
}