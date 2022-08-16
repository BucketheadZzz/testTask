using AutoMapper;
using testTaskAppB.BusinessLogic.BusinessObjects;
using testTaskAppB.BusinessLogic.Services.Interfaces;
using testTaskAppB.Repository.Entities;
using testTaskAppB.Repository.Repository;

namespace testTaskAppB.BusinessLogic.Services
{
    public class ShopItemService: IShopItemService
    {
        private readonly IRepository<ShopItem> _shopItemRepository;
        private readonly IMapper _mapper;

        public ShopItemService(IRepository<ShopItem> shopItemRepository, IMapper mapper)
        {
            _shopItemRepository = shopItemRepository;
            _mapper = mapper;
        }

        public async Task<List<ShopItemModel>> GetShopItemsByShopIdAsync(long shopId)
        {
            var entities = await _shopItemRepository.GetAsync(x => x.ShopItems.Any(y => y.Shop.Id == shopId));
            var result = _mapper.Map<List<ShopItemModel>>(entities);

            return result;
        }
    }
}
