﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Metani.Models;

namespace Metani.Controllers
{
    public class HasilTaniController : Controller
    {
        // GET: HasilTani
        public ActionResult Index()
        {
            if ((bool)Session["Login"])
            {
                MetaniContext context = new MetaniContext();
                return View(context.GetAllHasilTani());
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: JenisTani/Details/5
        public ActionResult Details(int id)
        {
            if ((bool)Session["Login"])
            {
                return View();
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: JenisTani/Create
        public ActionResult Create()
        {
            if ((bool)Session["Login"])
            {
                return View();
            }

            return RedirectToAction("Login", "Admin");
        }

        // POST: JenisTani/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            if ((bool)Session["Login"])
            {
                try
                {
                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: JenisTani/Edit/5
        public ActionResult Edit(int id)
        {
            if ((bool)Session["Login"])
            {
                return View();
            }

            return RedirectToAction("Login", "Admin");

        }

        // POST: JenisTani/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            if ((bool)Session["Login"])
            {
                try
                {
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: JenisTani/Delete/5
        public ActionResult Delete(int id)
        {
            if ((bool)Session["Login"])
            {
                return View();
            }

            return RedirectToAction("Login", "Admin");
        }

        // POST: JenisTani/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            if ((bool)Session["Login"])
            {
                try
                {
                    // TODO: Add delete logic here

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }

            return RedirectToAction("Login", "Admin");
        }
    }
}