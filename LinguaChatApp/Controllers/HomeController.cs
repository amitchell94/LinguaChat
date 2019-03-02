﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace LinguaChatApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if ( Session["user"] != null)
            {
                return Redirect("/chat");
            }

            return View();
        }
    }
}
