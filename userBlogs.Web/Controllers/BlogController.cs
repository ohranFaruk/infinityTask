using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using userBlogs.Data.Models;
using userBlogs.Web.Helpers;
using userBlogs.Web.ViewModels;
using static userBlogs.Web.ViewModels.BlogIndexVM;

namespace userBlogs.Web.Controllers
{

    [Autorizacija(true)]

    public class BlogController : Controller
    {

        private MyContext db;


        public BlogController(MyContext myContext)
        {
            db = myContext;
        }

               public IActionResult Index(int userId)
               {

            BlogIndexVM blogIndexVM = new BlogIndexVM
            {
                userId = userId,
                rows = db.Blogs.Where(x => x.UserId == userId).Select(x => new BlogIndexVM.row
                {

                    Title = x.Title,
                    dateTime = x.Date,
                    summary=x.Summary,
                    content=x.Content,
                    blogId=x.BlogsId
                    
                }).ToList()
            };

            blogIndexVM.rows = Sort(blogIndexVM);
        

            return View(blogIndexVM);
        }

        public IActionResult Snimi(BlogAddVM BlogAddVM)
        {
            Blogs blogs;

            if (BlogAddVM.blogId==0)
            {
                blogs = new Blogs();
                db.Blogs.Add(blogs);
            }
            else
            {
                blogs = db.Blogs.Where(x => x.BlogsId == BlogAddVM.blogId).FirstOrDefault();
            }

            blogs.Content = BlogAddVM.Content;
            blogs.Title = BlogAddVM.Title;
            blogs.Summary = BlogAddVM.summary;
            blogs.Date = BlogAddVM.datum;
            blogs.UserId = BlogAddVM.userId;

            db.SaveChanges();

            return Redirect("/User/details?userId="+BlogAddVM.userId);
        }

       public IActionResult CreateEdit(int userId,int? blogId)
        {
            BlogAddVM blogAddVM=new BlogAddVM();

            if (blogId==null)
            {
                blogAddVM.datum = DateTime.UtcNow.ToLocalTime();
                blogAddVM.userId = userId;
            }
            else
            {
                Blogs blog = db.Blogs.Where(x => x.BlogsId == blogId).FirstOrDefault();

                blogAddVM.blogId = blog.BlogsId;
                blogAddVM.datum = blog.Date;
                blogAddVM.Title = blog.Title;
                blogAddVM.Content = blog.Content;
                blogAddVM.userId = userId;
                blogAddVM.summary = blog.Summary;

            }

            return View(blogAddVM);

        }
     


   
        public List<BlogIndexVM.row> Sort (BlogIndexVM blogIndex)
        {

            List<BlogIndexVM.row> SortedList = blogIndex.rows.OrderBy(o => o.dateTime).ToList();
           return SortedList;
           
        }


    }
}