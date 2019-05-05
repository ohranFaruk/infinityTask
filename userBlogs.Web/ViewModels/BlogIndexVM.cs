using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace userBlogs.Web.ViewModels
{
    public class BlogIndexVM
    {
        public int userId { get; set; }

        public List<row> rows { get; set; }

        public class  row
        {
        public int blogId { get; set; }

        public string Title { get; set; }


        public string summary { get; set; }

            public string content { get; set; }


            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm dd MMM yyyy}")]
            public DateTime dateTime { get; set; }
    }
       

    }
}
