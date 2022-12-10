﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using DAL.Models;

namespace Pro_1_MVC_Learning.Controllers
{
    public class HomeController : Controller
    {
        DbContexts contexts = new DbContexts();

        // GET: Home
        public ActionResult Index()
        {
            return View(new User());
        }        
        public ActionResult Products()
        {
            return View();
        }
        public ActionResult News()
        {
            return View();
        }
        public ActionResult RegisterUser()
        {
            return View(new User());
        }
        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            if (!ModelState.IsValid || !user.Password.Equals(user.PasswordSlat))
            {
                return View("Index", user);
            }
            contexts.Users.Add(user);
            contexts.SaveChanges();
            return View("Index", user);
        }
        public JsonResult CheckValidation(string Word) {
            if (contexts.Users.Where(c => c.Username==Word || c.Phone==Word || c.Username==Word).FirstOrDefault() != null)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult ManagePanel()
        {
            return View();
        }
    }
}