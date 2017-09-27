using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EscalaDDD.Domain;
using EscalaDDD.Domain.Entities;

namespace EscalaDDD.Infra.Data.EntityConfig
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            HasKey(c => c.EmployeeCode);
            Property(c => c.Name).IsRequired().HasMaxLength(50);
            Property(c => c.NameComplete).IsRequired().HasMaxLength(200);
            Property(c => c.StarDate).IsRequired();
            Property(c => c.RegistrationDate).IsRequired();
            Property(c => c.EndDate).IsRequired();
            Property(c => c.CreateDate).IsRequired();
            Property(c => c.ModifyDate).IsRequired();

        }
    }
}
