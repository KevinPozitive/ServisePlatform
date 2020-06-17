using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ServiceProposal.Models;

namespace ServiceProposal
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            //using (CategoryContext db = new CategoryContext())
            //{
            //    // создаем два объекта User
            //    Category category1 = new Category { Name = "Дизайн и полиграфия" };
            //    Category category2 = new Category { Name = "Пример" };

            //    // добавляем их в бд
            //    db.Categories.Add(category1);
            //    db.Categories.Add(category2);
            //    db.SaveChanges();     
            //}


            //Database.SetInitializer(new CategoryContext.CategoryInitializer());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
