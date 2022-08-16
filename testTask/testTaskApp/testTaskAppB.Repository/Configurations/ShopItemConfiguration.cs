using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testTaskAppB.Repository.Entities;

namespace testTaskAppB.Repository.Configurations
{
    public class ShopItemConfiguration: IEntityTypeConfiguration<ShopItem>
    {
        public void Configure(EntityTypeBuilder<ShopItem> builder)
        {
            builder.ToTable("ShopItem");
            builder.HasKey(x => x.Id);
        }
    }
}
