namespace testTaskAppB.Repository.Entities
{
    public class ShopShopItem
    {
        public long Id { get; set; }

        public virtual Shop Shop { get; set; }

        public virtual ShopItem ShopItem { get; set; }
    }
}
