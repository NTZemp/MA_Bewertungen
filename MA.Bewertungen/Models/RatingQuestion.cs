using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MA.Bewertungen.Models
{
    public enum Rating
    {
        Bad,Okay,Good
    }
    public class RatingQuestion
    {
        public string Question { get; set; }
        public RatingQuestion Rating {get; set; }
        public string Comment { get; set; }
    }
}
