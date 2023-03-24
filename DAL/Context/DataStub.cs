using DAL.Context;
using DM;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using UserDM.Enums;

namespace DAL
{
    public class DataStub
    {
        public static void InitStub(IServiceProvider provider)
        {
            using (var context = new StubDBContext(provider.GetRequiredService<DbContextOptions<StubDBContext>>()))
            {
                for (int i = 0; i <= 10; i++)
                {
                    context.Tenants.Add(GenTenant());
                    context.SaveChangesAsync();
                }



            }

        }

        #region data generating zone
        private static Tenant GenTenant()
        {
            var tnt = new Tenant
            {
                CreationDate = DateTime.Now,
                Id = Guid.NewGuid()
            };

            return tnt;
        }
        private static User GenUser(Guid tId)
        {
            var usr = new User
            {
                Id = Guid.NewGuid(),
                TenantId = tId,
                Role = new List<UserRoles> { RndVal<UserRoles>() },
                UserInterests = new List<Interest> { new Interest{ } },
            };
            return usr;
        }
        private static T RndVal<T>()
        {
            var rnd = new Random();

            var val = Enum.GetValues(typeof(T));
            return (T)val.GetValue(rnd.Next(val.Length));
        }
        #endregion
    }
}