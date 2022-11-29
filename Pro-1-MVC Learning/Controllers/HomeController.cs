﻿using Pro_1_MVC_Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pro_1_MVC_Learning.Controllers
{
    public class HomeController:Controller
    {
        // Home/Index
        public ActionResult Index()
        {
            // Index
            return View();
        }
        // Home/News
        public ActionResult News()
        {
            // News
            return View();
        }
        // Home/Products
        public ActionResult Products()
        {
            return View();
        }
        // Home/Tools
        public ActionResult Tools()
        {
            return View();
        }
        // Home/Abouts
        public ActionResult About()
        {
            return View();
        }
        // Home/Manager
        public ActionResult Manager()
        {
            // Manager
            return View();
        }
        public ActionResult ManagerNews()
        {
            // ManagerNewa
            return View();
        }
    }
}