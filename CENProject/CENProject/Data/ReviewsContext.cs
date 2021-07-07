using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CENProject.Models;

namespace CENProject.Data
{
    public class ReviewsContext : DbContext
    {
        public ReviewsContext (DbContextOptions<ReviewsContext> options)
            : base(options)
        {
        }

        public DbSet<CENProject.Models.Review> Review { get; set; }
    }
}
