using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace userBlogs.Web.ViewModels
{
    public class BlogAddVM
    {
        public int userId { get; set; }
        public int blogId { get; set; }

        public string Title { get; set; }


        public string summary { get; set; }


       
        public string Content { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd MM yyyy}")]
        public DateTime datum { get; set; }


 


    }
}
