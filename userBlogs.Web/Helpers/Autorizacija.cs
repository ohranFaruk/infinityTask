using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using userBlogs.Data.Models;
using Microsoft.Extensions.DependencyInjection;

namespace userBlogs.Web.Helpers
{
    public class AutorizacijaAttribute : TypeFilterAttribute
    {
        public AutorizacijaAttribute(bool admin)
            : base(typeof(MyAuthorizeImpl))
        {
            Arguments = new object[] { admin, };
        }
    }


    public class MyAuthorizeImpl : IAsyncActionFilter
    {
        public MyAuthorizeImpl(bool admin)
        {
            _admin = admin;
            
        }
        private readonly bool _admin;
      
        public async Task OnActionExecutionAsync(ActionExecutingContext filterContext, ActionExecutionDelegate next)
        {
            KorisnickiNalog k = filterContext.HttpContext.GetLogiraniKorisnik();

            if (k == null)
            {
                if (filterContext.Controller is Controller controller)
                {
                    controller.TempData["error_poruka"] = "Niste logirani";
                }

                filterContext.Result = new RedirectToActionResult("Index", "Autentifikacija", new { @area = "" });
                return;
            }

            //Preuzimamo DbContext preko app services
            MyContext db = filterContext.HttpContext.RequestServices.GetService<MyContext>();

            //ucenici mogu pristupiti studenti
            if (_admin && db.KorisnickiNalog.Any(s => s.Id == k.Id))
            {
                await next(); //ok - ima pravo pristupa
                return;
            }

         
         
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // throw new NotImplementedException();
        }
    }
}
