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
            if ((bool)Session["Login"])
            {
                MetaniContext context = new MetaniContext();
                return View(context.GetAllLokasiTani());
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: Lokasi/Details/5
        public ActionResult Details(int id)
        {
            if ((bool)Session["Login"])
            {
                try
                {
                    MetaniContext context = new MetaniContext();
                    return View(context.FindLokasiTani(id));
                }
                catch
                {
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: Lokasi/Create
        public ActionResult Create()
        {
            if ((bool)Session["Login"])
            {
                return View();
            }

            return RedirectToAction("Login", "Admin");
        }

        // POST: Lokasi/Create
        [HttpPost]
        public ActionResult Create(string kecamatan, string kabupaten, string provinsi, string kodepos, decimal latitude, decimal longitude)
        {
            if ((bool)Session["Login"])
            {
                try
                {
                    MetaniContext context = new MetaniContext();
                    context.PostLokasi(kecamatan, kabupaten, provinsi, kodepos, latitude, longitude);

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: Lokasi/Edit/5
        public ActionResult Edit(int id)
        {
            if ((bool)Session["Login"])
            {
                MetaniContext context = new MetaniContext();
                return View(context.FindLokasiTani(id));
            }

            return RedirectToAction("Login", "Admin");
        }

        // POST: Lokasi/Edit/5
        [HttpPost]
        public ActionResult Edit(int idLokasi, string kecamatan, string kabupaten, string provinsi, string kodepos, decimal latitude, decimal longitude)
        {
            if ((bool)Session["Login"])
            {
                try
                {
                    MetaniContext context = new MetaniContext();
                    context.EditLokasi(idLokasi, kecamatan, kabupaten, provinsi, kodepos, latitude, longitude);

                    return RedirectToAction("Index");
                }
                catch
                {
                    return RedirectToAction("Create");
                }
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: Lokasi/Delete/5
        public ActionResult Delete(int id)
        {
            if ((bool)Session["Login"])
            {
                MetaniContext context = new MetaniContext();
                return View(context.FindLokasiTani(id));
            }

            return RedirectToAction("Login", "Admin");
        }
        
        // POST: Lokasi/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            if ((bool)Session["Login"])
            {
                try
                {
                    MetaniContext context = new MetaniContext();
                    context.DeleteLokasi(id);
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
