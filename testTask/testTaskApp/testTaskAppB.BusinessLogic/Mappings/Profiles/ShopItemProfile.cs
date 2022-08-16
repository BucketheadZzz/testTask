using AutoMapper;
using testTaskAppB.BusinessLogic.BusinessObjects;
using testTaskAppB.Repository.Entities;

namespace testTaskAppB.BusinessLogic.Mappings.Profiles
{
    public class ShopItemProfile : Profile
    {
        public ShopItemProfile()
        {
            CreateMap<ShopItem, ShopItemModel>();
        }
    }
}
