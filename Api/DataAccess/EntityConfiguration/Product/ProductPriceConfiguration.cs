using Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.DataAccess
{
    public class ProductPriceConfiguration : IEntityTypeConfiguration<ProductPrice>
    {
        #region Methods

        public void Configure(EntityTypeBuilder<ProductPrice> builder)
        {
            builder.ToTable("ProductPrices", "PDP");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Amount).IsRequired().HasColumnType("decimal(18,2)");
            builder.HasOne(p => p.Product)
                    .WithMany(c => c.ProductPrices)
                    .HasForeignKey(p => p.ProductId)
                    .OnDelete(DeleteBehavior.Cascade);
        }

        #endregion
    }
}
