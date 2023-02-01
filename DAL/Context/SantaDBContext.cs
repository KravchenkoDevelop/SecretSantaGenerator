using DM;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class SantaDBContext : DbContext
    {
        public SantaDBContext(DbContextOptions options) : base(options)
        {
        }
        
        public DbSet<UserData> UserDatas { get; set; }  
        public DbSet<User> Users { get; set; }

        public DbSet<Tenant> Tenants { get; set; }

        public DbSet<Interest> Interests { get; set; }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Event> Events { get; set; }


    }
}
