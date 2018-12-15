using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Metani.Models;

namespace Metani.Controllers
{
    public class JenisTaniController : Controller
    {
        // GET: JenisTani
        public ActionResult Index()
        {
            if ((bool)Session["Login"])
            {
                MetaniContext context = new MetaniContext();
                return View(context.GetAllJenisTani());
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: JenisTani/Details/5
        public ActionResult Details(int id)
        {
            if ((bool)Session["Login"])
            {
                try
                {
                    MetaniContext context = new MetaniContext();
                    //Console.WriteLine(namaJenisTani)

                    return View(context.FindJenisTani(id));

                }
                catch
                {
                    return RedirectToAction("Index");
                };
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
        public ActionResult Create(string namaJenisTani)
        {
            if ((bool)Session["Login"])
            {
                try
                {
                    MetaniContext context = new MetaniContext();
                    //Console.WriteLine(namaJenisTani);
                    context.PostJenisTani(namaJenisTani);
               
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
                MetaniContext context = new MetaniContext();
                return View(context.FindJenisTani(id));
            }

            return RedirectToAction("Login", "Admin");

        }

        // POST: JenisTani/Edit/5
        [HttpPost]
        public ActionResult Edit(int idJenisTani, string namaJenisTani)
        {
            if ((bool)Session["Login"])
            {
                try
                {
                    MetaniContext context = new MetaniContext();
                    context.EditJenisTani(idJenisTani, namaJenisTani);

                    return RedirectToAction("Index");
                }
                catch
                {
                    return RedirectToAction("Create");
                }
            }

            return RedirectToAction("Login", "Admin");

        }

        // GET: JenisTani/Delete/5
        public ActionResult Delete(int id)
        {
            if ((bool)Session["Login"])
            {
                MetaniContext context = new MetaniContext();
                return View(context.FindJenisTani(id));
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
                    MetaniContext context = new MetaniContext();
                    context.DeleteJenisTani(id);
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
