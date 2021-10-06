using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Api.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public string Boxoffice { get; set; }
        public string Active { get; set; }
        public DateTime DateOfLaunch { get; set; }
        public string Genre { get; set; }


    }
}
