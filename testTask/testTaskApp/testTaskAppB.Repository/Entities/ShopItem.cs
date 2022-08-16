
using System.Collections.Generic;

namespace testTaskAppB.Repository.Entities
{
    public class ShopItem
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<ShopShopItem> ShopItems { get; set; }
    }
}
