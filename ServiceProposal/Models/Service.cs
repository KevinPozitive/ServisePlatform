using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceProposal.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId{ get; set; }

    }
}