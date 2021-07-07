﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CENProject.Data;
using CENProject.Models;

namespace CENProject.Pages.Reviewers
{
    public class IndexModel : PageModel
    {
        private readonly CENProject.Data.ReviewersContext _context;

        public IndexModel(CENProject.Data.ReviewersContext context)
        {
            _context = context;
        }

        public IList<Reviewer> Reviewer { get;set; }

        public async Task OnGetAsync()
        {
            Reviewer = await _context.Reviewer.ToListAsync();
        }
    }
}
