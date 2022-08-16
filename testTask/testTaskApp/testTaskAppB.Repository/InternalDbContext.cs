using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace testTaskAppB.Repository
{
    public sealed class InternalDbContext : DbContext
    {
        public InternalDbContext(DbContextOptions<InternalDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseLazyLoadingProxies();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Assembly assemblyWithConfigurations = GetType().Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assemblyWithConfigurations);
        }
    }
}
