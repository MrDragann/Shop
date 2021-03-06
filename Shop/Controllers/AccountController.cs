﻿using Shop.Infrastructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Auth()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Auth(string userName, string password)
        {
            WebUser.Login(userName, password);
            return RedirectToAction("about");
        }
        [FilterUser(Roles = "Admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}