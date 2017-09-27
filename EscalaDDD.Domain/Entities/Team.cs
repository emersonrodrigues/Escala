using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalaDDD.Domain.Entities
{
    public class Team
    {
        public int TeamCode { get; set; }
        public int RosterCode { get; set; }
        public string Description { get; set; }
        public virtual Roster Roster { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
