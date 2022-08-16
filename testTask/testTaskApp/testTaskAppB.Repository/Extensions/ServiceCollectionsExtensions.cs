using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using testTaskAppB.Repository.Repository;

namespace testTaskAppB.Repository.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static void AddRepository(this IServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<InternalDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            serviceCollection.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
