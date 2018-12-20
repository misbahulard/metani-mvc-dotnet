using Metani.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Metani.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}