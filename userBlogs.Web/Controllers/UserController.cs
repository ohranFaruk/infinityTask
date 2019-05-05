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

    [Autorizacija(true)]
    public class UserController : Controller
    {
        private MyContext db;


        public UserController(MyContext myContext)
        {
            db = myContext;
        }



        public IActionResult Index()
        {

          

            var model = new UserIndexVM
            {
                rows = db.Users.Select(x => new UserIndexVM.Row
                {
                    name =x.Name,
                    age = x.Age,
                    email = x.Email,
                    blogs=db.Blogs.Where(y=>y.UserId==x.UserId).Count(),
                    userId=x.UserId


                }).OrderBy(x=>x.name).ToList()
            };



            return View(model);
        }

        public IActionResult Details(int userId)
        {
            

            User user = db.Users.Where(x => x.UserId == userId).FirstOrDefault();


            UserDetails model = new UserDetails
            {
                firstName= user.Name.Split()[0],
                lastName= user.Name.Split()[1],
                age = user.Age,
                userId = user.UserId,
                name=user.Name
              
            };

           return View(model);
        }

        public IActionResult Search(string nameOrEmail)
        {


            var model = new UserIndexVM
            {
                rows = db.Users.Where(x=>x.Name.Contains(nameOrEmail) || nameOrEmail==null || x.Email.Contains(nameOrEmail)).Select(x => new UserIndexVM.Row
                {
                   name=x.Name,
                    age = x.Age,
                    email = x.Email,
                    blogs = db.Blogs.Where(y => y.UserId == x.UserId).Count(),
                    userId = x.UserId


                }).OrderBy(x=>x.name).ToList()
            };

            return View("Index", model);


        }
    }
}