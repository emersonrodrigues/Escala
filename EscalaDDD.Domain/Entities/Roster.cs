using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalaDDD.Domain.Entities
{
    public class Roster
    {
        public int RosterCode { get; set; }
        public string Description { get; set; }
        public  virtual IEnumerable<Team> RosterTeam{ get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
