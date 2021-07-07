﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly CENProject.Data.PapersContext _context;

        public DetailsModel(CENProject.Data.PapersContext context)
        {
            _context = context;
        }

        public Paper Paper { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Paper = await _context.Paper.FirstOrDefaultAsync(m => m.PaperID == id);

            if (Paper == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
