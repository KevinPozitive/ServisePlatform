﻿using System;
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

        public ActionResult Category()
        {

            return View();
        }
    }
}