using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Entities
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        #region Methods

        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories", "PDP");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).IsRequired().HasMaxLength(50);
        }

        #endregion
    }
}
