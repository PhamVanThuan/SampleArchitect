using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;

namespace DataAccess
{
    public sealed class SampleContext: DbContext, ISampleContext
    {
        public SampleContext()
            : base("SampleConnection")
        {
            Database.SetInitializer<SampleContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                        base.OnModelCreating(modelBuilder);

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Person> Persons { get; set; }

    }
}
