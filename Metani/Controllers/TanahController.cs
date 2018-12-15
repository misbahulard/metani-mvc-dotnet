using Metani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Metani.Controllers
{
    public class TanahController : Controller
    {
        // GET: Tanah
        public ActionResult Index()
        {
            if ((bool)Session["Login"])
            {
                MetaniContext context = new MetaniContext();
                return View(context.GetAllTanahTani());
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: Tanah/Details/5
        public ActionResult Details(int id)
        {
            if ((bool)Session["Login"])
            {
                return View();  
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: Tanah/Create
        public ActionResult Create()
        {
            if ((bool)Session["Login"])
            {
                return View();  
            }

            return RedirectToAction("Login", "Admin");
        }

        // POST: Tanah/Create
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

        // GET: Tanah/Edit/5
        public ActionResult Edit(int id)
        {
            if ((bool)Session["Login"])
            {
                return View();
            }

            return RedirectToAction("Login", "Admin");
        }

        // POST: Tanah/Edit/5
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

        // GET: Tanah/Delete/5
        public ActionResult Delete(int id)
        {
            if ((bool)Session["Login"])
            {
                return View();
            }

            return RedirectToAction("Login", "Admin");
        }

        // POST: Tanah/Delete/5
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
