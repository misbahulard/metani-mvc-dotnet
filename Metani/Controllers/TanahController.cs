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
            MetaniContext context = new MetaniContext();
            return View(context.GetAllTanahTani());
        }

        // GET: Tanah/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tanah/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tanah/Create
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

        // GET: Tanah/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tanah/Edit/5
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

        // GET: Tanah/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tanah/Delete/5
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
