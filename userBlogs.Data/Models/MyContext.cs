using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using userBlogs.Data.Models;

namespace userBlogs.Data.Models
{
    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions<MyContext> x) : base(x)
        {

        }



        public DbSet<User> Users { get; set; }


        public DbSet<Blogs> Blogs { get; set; }


        public DbSet<KorisnickiNalog> KorisnickiNalog { get; set; }
    }
}
