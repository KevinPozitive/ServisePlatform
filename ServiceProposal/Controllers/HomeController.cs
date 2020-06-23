using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ServiceProposal.Models;


namespace ServiceProposal.Controllers
{
    public class HomeController : Controller
    {



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Category()
        {

            return View();
        }





        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // поиск пользователя в бд
                Provider user = null;
                using (ProviderContext db = new ProviderContext())
                {
                    user = db.Providers.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);

                }
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(model.Email, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Пользователя с таким логином и паролем нет");
                }
            }

            return View(model);
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                Provider user = null;
                using (ProviderContext db = new ProviderContext())
                {
                    user = db.Providers.FirstOrDefault(u => u.Email == model.Email);
                }
                if (user == null)
                {
                    // создаем нового пользователя
                    using (ProviderContext db = new ProviderContext())
                    {
                        db.Providers.Add(new Provider { Email = model.Email, Password = model.Password });
                        db.SaveChanges();

                        user = db.Providers.Where(u => u.Email == model.Email && u.Password == model.Password).FirstOrDefault();
                    }
                    // если пользователь удачно добавлен в бд
                    if (user != null)
                    {
                        FormsAuthentication.SetAuthCookie(model.Email, true);
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Пользователь с таким логином уже существует");
                }
            }

            return View(model);
        }
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }


    }
}