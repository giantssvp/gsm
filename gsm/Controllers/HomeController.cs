﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gsm.Controllers
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

        public ActionResult Courses()
        {
            ViewBag.Message = "Your course page.";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Your Blog page.";

            return View();
        }

        public ActionResult Feedback()
        {
            ViewBag.Message = "Your Blog page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Your Blog page.";

            return View();
        }
    }
}