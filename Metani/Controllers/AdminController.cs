using Metani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Metani.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            if ((bool) Session["Login"])
            {
                MetaniContext context = new MetaniContext();
                MapTani mapTani = new MapTani();
                List<MapList> hasilTaniList = new List<MapList>();
                List<HasilTaniJoin> hasilTani = context.GetAllHasilTaniJoin();
                foreach (var item in hasilTani)
                {
                    MapList mapList = new MapList();
                    mapList.nama = item.jenisTani.NamaJenisTani;
                    mapList.desc = item.Jumlah.ToString();
                    mapList.latitude = item.lokasi.Latitude;
                    mapList.longitude = item.lokasi.Longitude;

                    hasilTaniList.Add(mapList);
                }

                mapTani.HasilTani = hasilTaniList;

                List<MapList> tanahList = new List<MapList>();
                List<TanahJoin> tanah = context.GetAllTanahJoin();
                foreach (var item in tanah)
                {
                    MapList mapList = new MapList();
                    mapList.nama = item.JenisTanah.NamaJenisTanah;
                    mapList.desc = item.LuasTanah.ToString();
                    mapList.latitude = item.Lokasi.Latitude;
                    mapList.longitude = item.Lokasi.Longitude;

                    tanahList.Add(mapList);
                }

                mapTani.Tanah = tanahList;

                return View(mapTani);
            }

            return RedirectToAction("Login");
        }

        // GET: Admin/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Admin/Login
        [HttpPost]
        public ActionResult Login(User user)
        {
            try
            {
                MetaniContext context = new MetaniContext();
                User userDb = context.Login(user);
                if (userDb != null)
                {
                    Session["Login"] = true;
                    Session["Username"] = userDb.Username;
                    return RedirectToAction("Index", "Admin");
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

       public ActionResult Logout()
       {
            Session["Login"] = false;
            Session["Username"] = "";
            return RedirectToAction("Login");
       }
    }
}
