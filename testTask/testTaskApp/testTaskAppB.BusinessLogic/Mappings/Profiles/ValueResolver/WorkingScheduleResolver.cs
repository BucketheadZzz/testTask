using AutoMapper;
using testTaskAppB.BusinessLogic.BusinessObjects;
using testTaskAppB.Repository.Entities;

namespace testTaskAppB.BusinessLogic.Mappings.Profiles.ValueResolver
{
    public class WorkingScheduleResolver : IValueResolver<Shop, ShopModel, string>
    {
        public string Resolve(Shop source, ShopModel _, string destMember, ResolutionContext context)
        {
            var schedule = source.WorkingSchedule;
            return $"{schedule.StartTime} - {schedule.EndTime}";
        }
    }
}
