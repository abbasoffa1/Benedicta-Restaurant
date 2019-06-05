﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Benedicta.Helpers;

namespace Benedicta.Areas.Manage.Controllers
{
    [Auth]
    public class DashboardController : Controller
    {
        // GET: Manage/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}