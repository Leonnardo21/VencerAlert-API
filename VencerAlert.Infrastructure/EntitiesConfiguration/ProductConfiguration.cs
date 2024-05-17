using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VencerAlert.Domain.Entities;

namespace VencerAlert.Infrastructure.EntitiesConfiguration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(150).IsRequired();
            builder.Property(p => p.Presentation).HasMaxLength(200).IsRequired();
            builder.Property(p => p.CodeBar).IsRequired();
            builder.Property(p => p.Lot).IsRequired();
            builder.Property(p => p.FabricationDate).IsRequired();
            builder.Property(p => p.ExpirationDate).IsRequired();
            builder.Property(p => p.StatusProduct).IsRequired();
            builder.Property(p => p.ImageUrl).IsRequired();
            builder.Property(p => p.Quantity).IsRequired();
        }
    }
}
