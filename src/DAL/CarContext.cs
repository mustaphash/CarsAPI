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
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-HSU7GNR\\SQLEXPRESS;Initial Catalog=Cars;Integrated Security=True;Pooling=False");

            base.OnConfiguring(optionsBuilder);
        }

    }
}
