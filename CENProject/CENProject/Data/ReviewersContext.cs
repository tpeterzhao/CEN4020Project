using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CENProject.Models;

namespace CENProject.Data
{
    public class ReviewersContext : DbContext
    {
        public ReviewersContext (DbContextOptions<ReviewersContext> options)
            : base(options)
        {
        }

        public DbSet<CENProject.Models.Reviewer> Reviewer { get; set; }
    }
}
