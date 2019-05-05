using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace userBlogs.Web.ViewModels
{
    public class UserIndexVM
    {


        public List<Row> rows { get; set; }


        public class Row
        {
            public string name { get; set; }

            public int userId { get; set; }

            public string age { get; set; }

            public string email { get; set; }

            public int blogs { get; set; }
        }

        
    }
}
