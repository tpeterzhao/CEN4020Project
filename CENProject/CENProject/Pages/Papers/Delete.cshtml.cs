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
    public class DeleteModel : PageModel
    {
        private readonly CENProject.Data.PapersContext _context;

        public DeleteModel(CENProject.Data.PapersContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Paper = await _context.Paper.FindAsync(id);

            if (Paper != null)
            {
                _context.Paper.Remove(Paper);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
