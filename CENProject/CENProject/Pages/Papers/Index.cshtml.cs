using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CENProject.Data;
using CENProject.Models;

namespace CENProject.Pages.Papers
{
    public class IndexModel : PageModel
    {
        private readonly CENProject.Data.PapersContext _context;

        public IndexModel(CENProject.Data.PapersContext context)
        {
            _context = context;
        }

        public IList<Paper> Paper { get;set; }

        public async Task OnGetAsync()
        {
            Paper = await _context.Paper.ToListAsync();
        }
    }
}
