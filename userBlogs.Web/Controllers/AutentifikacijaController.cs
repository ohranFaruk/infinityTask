using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using userBlogs.Data.Models;
using userBlogs.Web.Helpers;
using userBlogs.Web.ViewModels;

namespace userBlogs.Web.Controllers
{
    public class AutentifikacijaController : Controller
    {


        private readonly MyContext _db;

        public AutentifikacijaController(MyContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(new Login()
            {
              
            });
        }

        public IActionResult Login(Login input)
        {
            KorisnickiNalog korisnik = _db.KorisnickiNalog.Where
                (x => x.username == input.username && x.password == input.password).FirstOrDefault();

            if (korisnik == null)
            {
                TempData["error_poruka"] = "pogrešan username ili password";
                return View("Index", input);
            }

             HttpContext.SetLogiraniKorisnik(korisnik);

            return RedirectToAction("Index", "User");
        }

        public IActionResult Logout()
        {

            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }

    }
}