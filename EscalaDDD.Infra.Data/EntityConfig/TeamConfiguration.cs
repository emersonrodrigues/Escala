using EscalaDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalaDDD.Infra.Data.EntityConfig
{
    public class TeamConfiguration : EntityTypeConfiguration<Team>
    {
        public TeamConfiguration()
        {
            HasKey( t => t.TeamCode);
            Property(t => t.Description).IsRequired().HasMaxLength(100);
            Property(t => t.RosterCode).IsRequired();
            Property(t => t.CreateDate).IsRequired();
            Property(t => t.ModifyDate).IsRequired();
        }
    }
}
