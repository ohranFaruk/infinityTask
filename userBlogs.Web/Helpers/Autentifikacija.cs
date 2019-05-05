using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using userBlogs.Data.Models;

namespace userBlogs.Web.Helpers
{
    public static class Autentifikacija
    {

        private const string LogiraniKornisnik = "logirani_korisnik";

        public static void SetLogiraniKorisnik(this HttpContext context,KorisnickiNalog admin)
        {
            context.Session.Set(LogiraniKornisnik, admin);
        }


        public static KorisnickiNalog GetLogiraniKorisnik(this HttpContext context)
        {
            KorisnickiNalog admin = context.Session.Get<KorisnickiNalog>(LogiraniKornisnik);
            return admin;
        }


    }
}
