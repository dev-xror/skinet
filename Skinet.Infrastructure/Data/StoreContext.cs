using Microsoft.EntityFrameworkCore;
using Skinet.Core.Entities;

namespace Skinet.Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        #region Constructors
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }
        #endregion

        #region DbSets
        public DbSet<Product> Products { get; set; }
        #endregion

    }
}