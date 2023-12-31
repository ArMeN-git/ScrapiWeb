﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace WebScrapingUI.Controllers
{
    public class LanguageController : Controller
    {
        // GET: Language
        public ActionResult Index(string language)
        {
            if (!String.IsNullOrEmpty(language))
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            }
            HttpCookie cookie = new HttpCookie("Languages");
            cookie.Value = language;
            Response.Cookies.Add(cookie);
            return RedirectToAction(TempData["currentAction"] as string, TempData["currentController"] as string);
        }
    }
}