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
        public DbSet<Service> Services { get; set; }

    }
}