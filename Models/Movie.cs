using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegLab21.Models
{
    public class Movie
    {

        public int id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public int year { get; set; }
        public List<string> actors { get; set; }
        public List<string> directors { get; set; } 



    }
}
