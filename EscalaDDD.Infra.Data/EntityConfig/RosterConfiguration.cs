using EscalaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalaDDD.Infra.Data.EntityConfig
{
    public class RosterConfiguration: EntityTypeConfiguration<Roster>
    {
        public RosterConfiguration()
        {
            HasKey(r => r.RosterCode);
            Property(r => r.Description).HasMaxLength(200);
            Property(r => r.CreateDate).IsRequired();
            Property(r => r.ModifyDate).IsRequired();

        }
    }
}
