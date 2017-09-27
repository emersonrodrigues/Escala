using EscalaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalaDDD.Domain.Entities
{
    public class Employee
    {
        public int EmployeeCode { get; set; }
        public string Name { get; set; }
        public string NameComplete { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int PIS { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual IEnumerator<Team>  Team{ get; set; }

    }
}
