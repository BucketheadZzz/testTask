using testTaskAppB.BusinessLogic.BusinessObjects;

namespace testTaskAppB.BusinessLogic.Services.Interfaces
{
    public interface IShopItemService
    {
        Task<List<ShopItemModel>> GetShopItemsByShopIdAsync(long shopId);
    }
}
