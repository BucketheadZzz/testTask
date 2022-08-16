using AutoMapper;
using testTaskAppB.BusinessLogic.BusinessObjects;
using testTaskAppB.BusinessLogic.Mappings.Profiles.ValueResolver;
using testTaskAppB.Repository.Entities;

namespace testTaskAppB.BusinessLogic.Mappings.Profiles
{
    public class ShopProfile: Profile
    {
        public ShopProfile()
        {
            CreateMap<Shop, ShopModel>()
                .ForMember(dest => dest.Address, opt => opt.MapFrom(ent => ent.Address.AddressDetails))
                .ForMember(dest => dest.WorkingSchedule, opt => opt.MapFrom<WorkingScheduleResolver>());
        }
    }
}
