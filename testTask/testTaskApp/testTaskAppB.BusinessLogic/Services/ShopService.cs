using AutoMapper;
using testTaskAppB.BusinessLogic.BusinessObjects;
using testTaskAppB.BusinessLogic.Services.Interfaces;
using testTaskAppB.Repository.Entities;
using testTaskAppB.Repository.Repository;

namespace testTaskAppB.BusinessLogic.Services
{
    public class ShopService : IShopService
    {
        private readonly IRepository<Shop> _shopRepository;
        private readonly IMapper _mapper;

        public ShopService(IRepository<Shop> shopRepository, IMapper mapper)
        {
            _shopRepository = shopRepository;
            _mapper = mapper;
        }

        public async Task<List<ShopModel>> GetAllShops()
        {
            var entities =  await _shopRepository.GetAsync();
            var result = _mapper.Map<List<ShopModel>>(entities);

            return result;
        }
    }
}
