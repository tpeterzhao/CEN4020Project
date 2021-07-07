using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CENProject.Data;
using CENProject.Models;

namespace CENProject.Pages.Reviewers
{
    public class CreateModel : PageModel
    {
        private readonly CENProject.Data.ReviewersContext _context;

        public CreateModel(CENProject.Data.ReviewersContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Reviewer Reviewer { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Reviewer.Add(Reviewer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
