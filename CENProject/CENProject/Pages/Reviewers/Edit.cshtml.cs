using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CENProject.Data;
using CENProject.Models;

namespace CENProject.Pages.Reviewers
{
    public class EditModel : PageModel
    {
        private readonly CENProject.Data.ReviewersContext _context;

        public EditModel(CENProject.Data.ReviewersContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Reviewer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReviewerExists(Reviewer.ReviewerID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ReviewerExists(int id)
        {
            return _context.Reviewer.Any(e => e.ReviewerID == id);
        }
    }
}
