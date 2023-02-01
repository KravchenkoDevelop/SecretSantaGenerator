using DM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class StubDBContext : DbContext
    {
        public StubDBContext(DbContextOptions options) : base(options)
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
