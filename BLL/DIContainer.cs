using DAL.Context;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DAL.Repo;

namespace BLL
{
    public static class DIContainer
    {
        public static void RegisterServices(this IServiceCollection collection)
        {
            #region debug and test area
#if DEBUG || MYTESTS

#endif
            #endregion

        }

        public static void RegiserDB(this IServiceCollection services)
        {
            services.AddTransient(typeof(IRepository<>),typeof(Repository<>));

#if DEBUG || MYTESTS
            services.AddDbContext<StubDBContext>(o => o.UseInMemoryDatabase("SantaDB"));
#endif
            services.AddDbContext<SantaDBContext>(ServiceLifetime.Singleton);

        }

    }
}
