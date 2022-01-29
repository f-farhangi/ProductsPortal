using Microsoft.EntityFrameworkCore;
using SearchApi.Entities;
using System.Reflection;

namespace SearchApi.DataAccess
{
    public class SearchDbContext : DbContext
    {
        #region Constructor

        public SearchDbContext(DbContextOptions<SearchDbContext> options) : base(options)
        {

        }

        #endregion

        #region DbSets

        public DbSet<SearchData> SearchDatas { get; set; }

        #endregion

        #region Methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #endregion
    }
}
