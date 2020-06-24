using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServiceProposal.Models
{
    public class ProvidersAndServicesContext : DbContext
    {
        public ProvidersAndServicesContext()
            : base("MyDB")
        { }
        public DbSet<ProvidersAndServices> ProvidersAndServices { get; set; }
    }
}