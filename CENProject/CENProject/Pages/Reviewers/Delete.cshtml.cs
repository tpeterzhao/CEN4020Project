using System;
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
    public class DeleteModel : PageModel
    {
        private readonly CENProject.Data.ReviewersContext _context;

        public DeleteModel(CENProject.Data.ReviewersContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Reviewer Reviewer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Reviewer = await _context.Reviewer.FirstOrDefaultAsync(m => m.ReviewerID == id);

            if (Reviewer == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Reviewer = await _context.Reviewer.FindAsync(id);

            if (Reviewer != null)
            {
                _context.Reviewer.Remove(Reviewer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
