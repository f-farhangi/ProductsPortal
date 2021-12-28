using Api.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Api.DataAccess
{
    public class AppDbContext : DbContext
    {
        #region Constructor

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        #endregion

        #region DbSets

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }

        #endregion

        #region Methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #endregion
    }
}
