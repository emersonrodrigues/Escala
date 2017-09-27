using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalaDDD.Domain.Entities
{
    public class ScheduleCycle
    {
        public int CycleCode { get; set; }
        public int SchedulePosition { get; set; }
        public int ScheduleCode { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual Cycle Cycle { get; set; }
        //public virtual IEnumerable<Schedule> Schedule { get; set; }
    }
}
