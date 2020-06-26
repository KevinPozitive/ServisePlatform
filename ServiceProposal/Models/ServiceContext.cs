using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ServiceProposal.Models
{
    public class ServiceContext: DbContext
    {
        public ServiceContext()
     : base("MyDB")
        {
        }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Service> Services { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provider>().HasMany(c => c.Services)
                .WithMany(s => s.Providers)
                .Map(t => t.MapLeftKey("ProviderId")
                .MapRightKey("ServiceId")
                .ToTable("ProvidersAndServices"));
        }
    }
}