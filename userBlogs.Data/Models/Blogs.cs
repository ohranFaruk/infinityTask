using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace userBlogs.Data.Models
{
    public class Blogs
    {

        [Key]
        public int BlogsId { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(64)]
        public string Title { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(350)]
        public string Summary { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(3500)]
        public string Content { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public DateTime Date { get; set; }


        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
