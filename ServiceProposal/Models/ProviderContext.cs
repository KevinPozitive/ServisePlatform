using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ServiceProposal.Models
{
    public class ProviderContext : DbContext
    {
        public ProviderContext()
           : base("MyDB")
        { }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Service> Services { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasMany(c => c.Providers)
                .WithMany(s => s.Services)
                .Map(t => t.MapLeftKey("ServiceId")
                .MapRightKey("ProviderId")
                .ToTable("ProvidersAndServices"));
        }
    }
}