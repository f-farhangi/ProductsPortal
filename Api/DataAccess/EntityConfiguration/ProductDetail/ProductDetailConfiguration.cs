using Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.DataAccess
{
    public class ProductDetailConfiguration : IEntityTypeConfiguration<ProductDetail>
    {
        #region Methods

        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.ToTable("ProductDetails", "PDP");
            builder.HasKey(pd => pd.Id);
            builder.HasOne(pd => pd.Product)
                    .WithMany(p => p.ProductDetails)
                    .HasForeignKey(pd => pd.ProductId)
                    .OnDelete(DeleteBehavior.Cascade);
        }

        #endregion
    }
}
