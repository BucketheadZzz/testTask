using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using testTaskAppB.BusinessLogic.Services;
using testTaskAppB.BusinessLogic.Services.Interfaces;

namespace testTaskAppB.BusinessLogic.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddBusinessLogicServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IShopService, ShopService>();
            serviceCollection.AddScoped<IShopItemService, ShopItemService>();
        }

        public static void AddAutoMapperProfiles(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
