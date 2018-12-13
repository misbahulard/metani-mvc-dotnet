using System;
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
            MetaniContext context = new MetaniContext();
            return View(context.GetAllHasilTani());
        }

        // GET: JenisTani/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JenisTani/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JenisTani/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: JenisTani/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JenisTani/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: JenisTani/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JenisTani/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
    }
}