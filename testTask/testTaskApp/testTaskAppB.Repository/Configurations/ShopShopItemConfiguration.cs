using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testTaskAppB.Repository.Entities;

namespace testTaskAppB.Repository.Configurations
{
    public class ShopShopItemConfiguration : IEntityTypeConfiguration<ShopShopItem>
    {
        public void Configure(EntityTypeBuilder<ShopShopItem> builder)
        {
            builder.ToTable("ShopShopItemMapping");
            builder.HasKey(x => x.Id);
        }
    }
}
