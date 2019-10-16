using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MA.Bewertungen.Models
{
    public class EmployeeRating
    {
        public virtual ICollection<RatingQuestion> Rating { get; set; }
    }
}
