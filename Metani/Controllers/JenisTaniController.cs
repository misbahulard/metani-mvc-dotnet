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
            MetaniContext context = new MetaniContext();
            return View(context.GetAllJenisTani());
        }

        // GET: JenisTani/Details/5
        public ActionResult Details(int id)
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
            }
        }

        // GET: JenisTani/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JenisTani/Create
        [HttpPost]
        public ActionResult Create(string namaJenisTani)
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

        // GET: JenisTani/Edit/5
        public ActionResult Edit(int id)
        {
            MetaniContext context = new MetaniContext();
            return View(context.FindJenisTani(id));
        }

        // POST: JenisTani/Edit/5
        [HttpPost]
        public ActionResult Edit(int idJenisTani, string namaJenisTani)
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

        // GET: JenisTani/Delete/5
        public ActionResult Delete(int id)
        {
            MetaniContext context = new MetaniContext();
            return View(context.FindJenisTani(id));
        }

        // POST: JenisTani/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
    }
}
