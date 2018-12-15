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
            if ((bool)Session["Login"])
            {
                MetaniContext context = new MetaniContext();
                return View(context.GetAllJenisTanah());
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: JenisTanah/Details/5
        public ActionResult Details(int id)
        {
            if ((bool)Session["Login"])
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

            return RedirectToAction("Login", "Admin");
        }

        // GET: JenisTanah/Create
        public ActionResult Create()
        {
            if ((bool)Session["Login"])
            {
                return View();
            }

            return RedirectToAction("Login", "Admin");
        }

        // POST: JenisTanah/Create
        [HttpPost]
        public ActionResult Create(string namaJenisTanah)
        {
            if ((bool)Session["Login"])
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

            return RedirectToAction("Login", "Admin");
        }

        // GET: JenisTanah/Edit/5
        public ActionResult Edit(int id)
        {
            if ((bool)Session["Login"])
            {
                MetaniContext context = new MetaniContext();
                return View(context.FindJenisTanah(id));
            }

            return RedirectToAction("Login", "Admin");
        }

        // POST: JenisTanah/Edit/5
        [HttpPost]
        public ActionResult Edit(int idJenisTanah, string namaJenisTanah)
        {
            if ((bool)Session["Login"])
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

            return RedirectToAction("Login", "Admin");
        }

        // GET: JenisTanah/Delete/5
        public ActionResult Delete(int id)
        {
            if ((bool)Session["Login"])
            {
                MetaniContext context = new MetaniContext();
                return View(context.FindJenisTanah(id));
            }

            return RedirectToAction("Login", "Admin");
        }

        // POST: JenisTanah/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            if ((bool)Session["Login"])
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

            return RedirectToAction("Login", "Admin");
        }
    }
}
