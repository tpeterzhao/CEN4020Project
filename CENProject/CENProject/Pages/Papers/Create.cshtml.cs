using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CENProject.Data;
using CENProject.Models;

namespace CENProject.Pages.Papers
{
    public class CreateModel : PageModel
    {
        private readonly CENProject.Data.PapersContext _context;

        public CreateModel(CENProject.Data.PapersContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Paper Paper { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Paper.Add(Paper);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
