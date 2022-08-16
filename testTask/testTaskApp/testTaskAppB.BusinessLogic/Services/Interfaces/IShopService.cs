

using testTaskAppB.BusinessLogic.BusinessObjects;

namespace testTaskAppB.BusinessLogic.Services.Interfaces
{
    public interface IShopService
    {
        Task<List<ShopModel>> GetAllShopsAsync();
    }
}
