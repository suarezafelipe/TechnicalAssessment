using SanaWebShop.Core.RepositoriesInterfaces;
using SanaWebShop.Core.Services;

namespace SanaWebShop.Core
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }

        void Complete();
        void CompleteAsync();
    }
}