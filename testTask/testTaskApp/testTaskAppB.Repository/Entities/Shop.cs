using System.Collections.Generic;

namespace testTaskAppB.Repository.Entities
{
    public class Shop
    {
        protected Shop()
        {
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public virtual WorkingSchedule WorkingSchedule { get; set; }

        public virtual Address Address { get; set; }

        public virtual ICollection<ShopShopItem> ShopShopItem { get; set; }
    }
}
