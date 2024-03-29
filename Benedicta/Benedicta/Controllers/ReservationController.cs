﻿using Benedicta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Benedicta.Controllers
{
    public class ReservationController : Controller
    {
        private readonly BenedictaContext db = new BenedictaContext();

        public ActionResult Index()
        {
            AddView model = new AddView();
            model.Settings = db.Setting.OrderByDescending(s => s.Id).Take(1).ToList();
            model.ReserveTables = db.ReserveTable.OrderByDescending(r => r.Id).Take(1).ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(ReserveTable table)
        {
            db.ReserveTable.Add(table);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}