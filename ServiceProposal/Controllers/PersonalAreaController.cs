using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceProposal.Models;

namespace ServiceProposal.Controllers
{
    public class PersonalAreaController : Controller
    {
        // GET: PersonalArea
        ProviderContext dbProvider = new ProviderContext();
        [Authorize]
        public ActionResult Parlor()
        {
            Provider provider = dbProvider.Providers.FirstOrDefault(u => u.Email == User.Identity.Name);

            //ViewBag.provider = provider;
            return View(provider);
        }


    }
}