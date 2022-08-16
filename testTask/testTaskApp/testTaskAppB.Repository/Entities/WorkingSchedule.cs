
using System;

namespace testTaskAppB.Repository.Entities
{
    public class WorkingSchedule
    {
        public long Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
