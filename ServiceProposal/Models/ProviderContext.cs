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
           : base("ProviderContext")
        { }
        public DbSet<Provider> Providers { get; set; }
    }
}