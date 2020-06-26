using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        ProvidersAndServicesContext db = new ProvidersAndServicesContext();
        [Authorize]
        public ActionResult Parlor()
        {
            Provider provider = dbProvider.Providers.FirstOrDefault(u => u.Email == User.Identity.Name);

            //ViewBag.provider = provider;
            return View(provider);
        }

        public ActionResult Edit(int id = 0)
        {
            Provider provider = dbProvider.Providers.Find(id);
            if (provider == null)
            {
                return HttpNotFound();
            }
            ViewBag.Services = dbProvider.Services.ToList();
            return View(provider);
        }

        [HttpPost]
        public ActionResult Edit(Provider provider, int[] selectedServices)
        {
            Provider newProvider = dbProvider.Providers.Find(provider.Id);
            newProvider.FirstName = provider.FirstName;
            newProvider.SecondName = provider.SecondName;
            newProvider.TelNumber = provider.TelNumber;

            newProvider.Services.Clear();
            if (selectedServices != null)
            {
                //получаем выбранные курсы
                foreach (var c in dbProvider.Services.Where(co => selectedServices.Contains(co.Id)))
                {
                    newProvider.Services.Add(c);
                }
            }
            
            dbProvider.Entry(newProvider).State = EntityState.Modified;
            dbProvider.SaveChanges();
            return RedirectToAction("Parlor");
        }














        //[HttpGet]
        //public ActionResult Delete(int id) {
        //    ProvidersAndServices ps = dbProvidersAndServices.ProvidersAndServices.Find(id);
        //    if (ps != null) {
        //        dbProvidersAndServices.ProvidersAndServices.Remove(ps);
        //        dbProvider.SaveChanges();
        //    }
        //    return RedirectToAction("Parlor");
        //}
        //[HttpGet]
        //public ActionResult Delete(int id)
        //{
        //    ProvidersAndServices b = dbProvidersAndServices.ProvidersAndServices.FirstOrDefault(s => s.ServiceId == id);
        //    if (b == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(b);
        //}
        //[HttpPost, ActionName("Delete")]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    ProvidersAndServices b = dbProvidersAndServices.ProvidersAndServices.FirstOrDefault(s => s.ServiceId == id);
        //    if (b == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    dbProvidersAndServices.ProvidersAndServices.Remove(b);
        //    dbProvidersAndServices.SaveChanges();
        //    return RedirectToAction("Parlor");
        //}

    }
}