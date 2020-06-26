using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceProposal.Models;

namespace ServiceProposal.Controllers
{
    public class CategoryController : Controller
    {
        CategoryContext dbCategory = new CategoryContext();

        ServiceContext dbService = new ServiceContext();
        // GET: Category
        public ActionResult Category()
        {
            var categories = dbCategory.Categories;
            ViewBag.Categories = categories;
            
            var services = dbService.Services;
            ViewBag.Services = services;
            
            

            return View();
        }

    }
}