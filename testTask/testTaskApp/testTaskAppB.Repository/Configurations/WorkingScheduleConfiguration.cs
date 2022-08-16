using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using testTaskAppB.Repository.Entities;

namespace testTaskAppB.Repository.Configurations
{
    public class WorkingScheduleConfiguration: IEntityTypeConfiguration<WorkingSchedule>
    {
        public void Configure(EntityTypeBuilder<WorkingSchedule> builder)
        {
            builder.ToTable("WorkingSchedule");
            builder.HasKey(x => x.Id);
        }
    }
}
