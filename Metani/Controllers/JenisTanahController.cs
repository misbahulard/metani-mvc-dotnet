using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Metani.Models;

namespace Metani.Controllers
{
    public class JenisTanahController : Controller
    {
        // GET: JenisTanah
        public ActionResult Index()
        {
            MetaniContext context = new MetaniContext();
            return View(context.GetAllJenisTanah());
        }

        // GET: JenisTanah/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                MetaniContext context = new MetaniContext();
                return View(context.FindJenisTanah(id));

            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // GET: JenisTanah/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JenisTanah/Create
        [HttpPost]
        public ActionResult Create(string namaJenisTanah)
        {
            try
            {
                MetaniContext context = new MetaniContext();
                context.PostJenisTanah(namaJenisTanah);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: JenisTanah/Edit/5
        public ActionResult Edit(int id)
        {
            MetaniContext context = new MetaniContext();
            return View(context.FindJenisTanah(id));
        }

        // POST: JenisTanah/Edit/5
        [HttpPost]
        public ActionResult Edit(int idJenisTanah, string namaJenisTanah)
        {
            try
            {
                MetaniContext context = new MetaniContext();
                context.EditJenisTanah(idJenisTanah, namaJenisTanah);

                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Create");
            }
        }

        // GET: JenisTanah/Delete/5
        public ActionResult Delete(int id)
        {
            MetaniContext context = new MetaniContext();
            return View(context.FindJenisTanah(id));
        }

        // POST: JenisTanah/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                MetaniContext context = new MetaniContext();
                context.DeleteJenisTanah(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
