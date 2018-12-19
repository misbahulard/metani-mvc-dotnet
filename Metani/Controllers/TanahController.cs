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
                return View(context.GetAllTanahJoin());
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: Tanah/Details/5
        public ActionResult Details(int id)
        {
            if ((bool)Session["Login"])
            {
                MetaniContext context = new MetaniContext();
                TanahJoin tanahJoin = context.FindTanahJoin(id);
                return View(tanahJoin);
            }

            return RedirectToAction("Login", "Admin");
        }

        // GET: Tanah/Create
        public ActionResult Create()
        {
            if ((bool)Session["Login"])
            {
                MetaniContext context = new MetaniContext();
                List<JenisTanah> jenisTanah = context.GetAllJenisTanah();
                List<Lokasi> lokasi = context.GetAllLokasiTani();

                Tanah tanah = new Tanah();

                TanahLokasi tanahLokasi = new TanahLokasi { jenisTanah = jenisTanah.ToArray(), lokasi = lokasi.ToArray(), tanah = tanah };
                return View(tanahLokasi);
            }

            return RedirectToAction("Login", "Admin");
        }

        // POST: Tanah/Create
        [HttpPost]
        public ActionResult Create(int idJenisTanah, int luasTanah, int suhu, int idLokasi)
        {
            if ((bool)Session["Login"])
            {
                try
                {
                    MetaniContext context = new MetaniContext();
                    context.PostTanah(idJenisTanah, luasTanah, suhu, idLokasi);

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
                MetaniContext context = new MetaniContext();
                List<JenisTanah> jenisTanah = context.GetAllJenisTanah();
                List<Lokasi> lokasi = context.GetAllLokasiTani();
                Tanah tanah = context.FindTanah(id);

                TanahLokasi tanahLokasi = new TanahLokasi { jenisTanah = jenisTanah.ToArray(), lokasi = lokasi.ToArray(), tanah = tanah };

                return View(tanahLokasi);
            }

            return RedirectToAction("Login", "Admin");
        }

        // POST: Tanah/Edit/5
        [HttpPost]
        public ActionResult Edit(int idTanah, int idJenisTanah, int luasTanah, int suhu, int idLokasi)
        {
            if ((bool)Session["Login"])
            {
                try
                {
                    MetaniContext context = new MetaniContext();
                    context.EditTanah(idTanah, idJenisTanah, luasTanah, suhu, idLokasi);

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
                MetaniContext context = new MetaniContext();
                return View(context.FindTanahJoin(id));
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
                    MetaniContext context = new MetaniContext();
                    context.DeleteTanah(id);
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
