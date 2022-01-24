using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configs
{
    public class OwnerConfig : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasKey(o => o.Id);

            builder.Property(o => o.FirstName).HasMaxLength(250).IsRequired();
            builder.Property(o => o.LastName).HasMaxLength(250).IsRequired();
            builder.Property(o => o.City).IsRequired();
            builder.Property(o => o.PurchaseDate).IsRequired();
        }
    }
}
