using MA.Bewertungen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MA.Bewertungen.Data
{
    public class RatingContext : DbContext
    {
        public RatingContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeRating> EmployeeRatings { get; set; }
        public DbSet<RatingQuestion> RatingQuestions { get; set; }

    }
}
