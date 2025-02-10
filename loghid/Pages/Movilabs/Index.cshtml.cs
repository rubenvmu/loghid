using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Movilabs
{
    public class IndexModel : PageModel
    {
        private readonly Loghid.Data.eSprinterLabShimadzuDbContext _context;

        public IndexModel(Loghid.Data.eSprinterLabShimadzuDbContext context)
        {
            _context = context;
        }

        public IList<eSprinterLab> eSprinterLab { get;set; } = default!;

        public async Task OnGetAsync()
        {
            eSprinterLab = await _context.eSprinterLab.ToListAsync();
        }
    }
}
