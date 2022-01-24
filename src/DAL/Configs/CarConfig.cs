using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class CarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Make).HasMaxLength(250).IsRequired();
            builder.Property(c => c.Model).HasMaxLength(250).IsRequired();
            builder.Property(c => c.Kilometers).IsRequired();
            builder.Property(c => c.Transmission).IsRequired();
            builder.Property(c => c.Color).IsRequired();
            builder.Property(c => c.Fuel).IsRequired();
            builder.Property(c => c.DateOfManufacture).IsRequired();
        }
    }
}
