using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Formaldehydepage
{
    public class DetailsModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public DetailsModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        public Formaldehyde Formaldehyde { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formaldehyde = await _context.Formaldehyde.FirstOrDefaultAsync(m => m.Id == id);

            if (formaldehyde is not null)
            {
                Formaldehyde = formaldehyde;

                return Page();
            }

            return NotFound();
        }
    }
}
