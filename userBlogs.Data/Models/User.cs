using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace userBlogs.Data.Models
{
    public class User
    {
        [Key]

        public int UserId { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public string Age { get; set; }



        [ForeignKey(nameof(KorisnickiNalog))]
        public int? KorisnickiNalogId { get; set; }
        public KorisnickiNalog KorisnickiNalog { get; set; }
    }
}
