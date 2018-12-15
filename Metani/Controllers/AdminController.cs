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
                return View();
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
                    return RedirectToAction("Index");
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
