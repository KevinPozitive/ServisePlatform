using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceProposal.Models
{
    public class Provider
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Password { get; set; }

        public string TelNumber { get; set; }

        public string Email { get; set; }
    }
}