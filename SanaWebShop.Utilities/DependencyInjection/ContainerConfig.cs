using Autofac;
using SanaWebShop.Persistence;
using SanaWebShop.Persistence.Repositories;
using SanaWebShop.Core.RepositoriesInterfaces;
using SanaWebShop.Core.Services;


namespace SanaWebShop.Utilities.DependencyInjection
{
    public class ContainerConfig
    {
        public static void RegisterContainer(ContainerBuilder builder)
        {
            builder.RegisterType<SanaWebShopDbContext>().As<ISanaWebShopDbContext>().AsSelf();
            builder.RegisterType<ProductRepository>().As<IProductRepository>().AsSelf();
            builder.RegisterType<ProductService>().As<IProductService>().AsSelf();

        }

    }
}
