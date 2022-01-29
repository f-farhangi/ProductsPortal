using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SearchApi.Entities;

namespace SearchApi.DataAccess
{
    public class SearchDataConfiguration : IEntityTypeConfiguration<SearchData>
    {
        #region Methods

        public void Configure(EntityTypeBuilder<SearchData> builder)
        {
            builder.ToTable("SearchDatas", "SD");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductId).IsRequired();
            builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(250);
        }

        #endregion
    }
}
