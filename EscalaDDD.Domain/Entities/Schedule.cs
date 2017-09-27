using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalaDDD.Domain.Entities
{
    public class Schedule
    {
        public int ScheduleCode { get; set; }
        public string Description { get; set; }
        public int StartMinute { get; set; }
        public int EndMinuto { get; set; }
        public int StartMealMinute { get; set; }
        public int EndMealMinute { get; set; }
        public virtual IEnumerator<ScheduleCycle> ScheduleCycles { get; set; }
    }
}
