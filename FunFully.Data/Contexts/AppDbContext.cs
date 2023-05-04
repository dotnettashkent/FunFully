using FunFully.Domain.Entities.Moneys;
using FunFully.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace FunFully.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Money> Moneys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection", b => b.MigrationsAssembly("FunFully.Api"));
            }
        }
    }
}
