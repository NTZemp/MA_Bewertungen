using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MA.Bewertungen.Models
{
    public interface Employee
    {
        string Id { get; set; }

        EmployeeRating Rating { get; set; }

    }
}
