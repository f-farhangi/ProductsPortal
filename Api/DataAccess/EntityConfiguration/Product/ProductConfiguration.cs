using Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.DataAccess
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        #region Methods

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products", "PDP");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(250);
            builder.HasOne(p => p.Category)
                    .WithMany(c => c.Products)
                    .HasForeignKey(p => p.CategoryId)
                    .OnDelete(DeleteBehavior.Cascade);
        }

        #endregion
    }
}
