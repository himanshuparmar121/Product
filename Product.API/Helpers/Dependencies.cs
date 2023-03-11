using Product.Data.IRepository;
using Product.Data.Repository;
using Product.Service.IServices;
using Product.Service.Services;

namespace Product.API.Helpers
{
    public class Dependencies
    {
        public static void Dependency(IServiceCollection services)
        {
            services.AddTransient<IItemService, ItemService>();
            services.AddTransient<IItemRepository, Item>();
            services.AddTransient<IItemObjectsService, ItemObjectsService>();
            services.AddTransient<IItemObjectsRepository, ItemObjects>();
        }
    }
}
