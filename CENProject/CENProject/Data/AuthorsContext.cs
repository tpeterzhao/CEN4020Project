using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CENProject.Models;

namespace CENProject.Data
{
    public class AuthorsContext : DbContext
    {
        public AuthorsContext (DbContextOptions<AuthorsContext> options)
            : base(options)
        {
        }

        public DbSet<CENProject.Models.Author> Author { get; set; }
    }
}
