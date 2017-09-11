using System.Data.Entity;
using SanaWebShop.Core.Models;

namespace SanaWebShop.Persistence
{
    public class SanaWebShopDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductsPerCategory> ProductsPerCategories { get; set; }
        
        public SanaWebShopDbContext() : base("SanaWebShopDbConnection")
        {
            
        }
    }
}
