using System.Data.Entity;
using SanaWebShop.Core.Models;

namespace SanaWebShop.Persistence
{
    public interface ISanaWebShopDbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductsPerCategory> ProductsPerCategories { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<ProductsPerOrder> ProductsPerOrders { get; set; }
    }
}