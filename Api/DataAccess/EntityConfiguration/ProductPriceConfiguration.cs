using Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.DataAccess.EntityConfiguration
{
    public class ProductPriceConfiguration : IEntityTypeConfiguration<ProductPrice>
    {
        #region Methods

        public void Configure(EntityTypeBuilder<ProductPrice> builder)
        {
            builder.ToTable("ProductPrices", "PDP");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Amount).HasColumnType("decimal(18,2)").IsRequired();

            builder.HasOne(p => p.Product)
                    .WithMany(c => c.ProductPrices)
                    .HasForeignKey(p => p.ProductId)
                    .IsRequired();
        }

        #endregion
    }
    
}
