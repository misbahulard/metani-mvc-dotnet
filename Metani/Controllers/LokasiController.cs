﻿using System;
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

        // GET: Lokasi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lokasi/Create
        [HttpPost]
        public ActionResult Create(string kecamatan, string kabupaten, string provinsi, string kodepos, decimal latitude, decimal longitude)
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

        // GET: Lokasi/Edit/5
        public ActionResult Edit(int id)
        {
            MetaniContext context = new MetaniContext();
            return View(context.FindLokasiTani(id));
        }

        // POST: Lokasi/Edit/5
        [HttpPost]
        public ActionResult Edit(int idLokasi, string kecamatan, string kabupaten, string provinsi, string kodepos, decimal latitude, decimal longitude)
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

        // GET: Lokasi/Delete/5
        public ActionResult Delete(int id)
        {
            MetaniContext context = new MetaniContext();
            return View(context.FindLokasiTani(id));
        }
        
        // POST: Lokasi/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
    }
}
