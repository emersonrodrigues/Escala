using EscalaDDD.Domain;
using EscalaDDD.Domain.Entities;
using EscalaDDD.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalaDDD.Infra.Data.Context
{
    public class EscalaContext : DbContext
    {

        public EscalaContext() : base("ConnectionBD")
        { }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Roster> Roster { get; set; }
        public DbSet<Team> Team { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //Remove o plural do nome das tabelas, deixando o nome definido na classe
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); // Remove o delete em cascata nos relacionamento um para muitos
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();// Remove o delete em cascata nos relacionamento muitos para muitos
            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());// defini que campo vai ser a key automaticamente
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar")); // configura que sempre que eu tiver um tipo string ele vai gravar na tabela como varchar, o padra é nvarchar
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100)); // Configura o tamanha dos campos strings como 100 como padrao
            modelBuilder.Configurations.Add(new EmployeeConfiguration()); //Adciona a configuração especifica da tabela cliente
            modelBuilder.Configurations.Add(new RosterConfiguration()); //Adciona a configuração especifica da tabela produto
            modelBuilder.Configurations.Add(new TeamConfiguration());
        }
        //Automatizando a data de criação e a data de modificação
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreateDate").CurrentValue = DateTime.Now;
                    entry.Property("ModifyDate").CurrentValue = DateTime.Now;
                }
                else
                {
                    if (entry.State == EntityState.Modified)
                    {
                        entry.Property("ModifyDate").CurrentValue = DateTime.Now;
                    }
                    else
                    {
                        entry.Property("CreateDate").IsModified = false;
                    }
                }

            }
            return base.SaveChanges();
        }

    }
    }
    

