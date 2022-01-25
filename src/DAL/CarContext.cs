using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class CarsContext : DbContext
    {
        public CarsContext()
        {
        }
        public CarsContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Owner> Owners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(b => b.MigrationsAssembly("Cars"));

            base.OnConfiguring(optionsBuilder);
        }

    }
}
