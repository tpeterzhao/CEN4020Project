using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CENProject.Models;

namespace CENProject.Data
{
    public class PapersContext : DbContext
    {
        public PapersContext (DbContextOptions<PapersContext> options)
            : base(options)
        {
        }

        public DbSet<CENProject.Models.Paper> Paper { get; set; }
    }
}
