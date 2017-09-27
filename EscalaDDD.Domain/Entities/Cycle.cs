using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalaDDD.Domain.Entities
{
    public class Cycle
    {
        public int CycleCode { get; set; }
        public string Description { get; set; }
        
        public virtual IEnumerable<ScheduleCycle> ScheduleCycle { get; set; }




    }
}
