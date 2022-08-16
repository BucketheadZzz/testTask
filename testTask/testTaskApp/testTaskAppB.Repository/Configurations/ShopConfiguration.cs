using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testTaskAppB.Repository.Entities;

namespace testTaskAppB.Repository.Configurations
{
    public class ShopConfiguration: IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.ToTable("Shop");
            builder.HasKey(x => x.Id);
        }
    }
}
