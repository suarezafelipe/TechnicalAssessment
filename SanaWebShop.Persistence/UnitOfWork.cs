using SanaWebShop.Core;
using SanaWebShop.Core.RepositoriesInterfaces;
using SanaWebShop.Core.Services;
using SanaWebShop.Persistence.ApplicationDbContext;
using SanaWebShop.Persistence.Repositories;

namespace SanaWebShop.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SanaWebShopDbContext _context;

        public IProductRepository Products { get; private set; }

        public UnitOfWork(SanaWebShopDbContext context)
        {
            _context = context;
            Products = new ProductRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public void CompleteAsync()
        {
            _context.SaveChangesAsync();
        }
    }
}
