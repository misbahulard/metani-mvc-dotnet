using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Metani.Models;

namespace Metani.Controllers
{
    public class LokasiController : Controller
    {
        // GET: Lokasi
        public ActionResult Index()
        {
            MetaniContext context = new MetaniContext();
            return View(context.GetAllLokasiTani());
        }

        // GET: Lokasi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lokasi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lokasi/Create
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

        // GET: Lokasi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lokasi/Edit/5
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

        // GET: Lokasi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lokasi/Delete/5
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
