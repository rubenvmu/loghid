using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Ammoniapage
{
    public class IndexModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public IndexModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        public IList<Ammonia> Ammonia { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Ammonia = await _context.Ammonia.ToListAsync();
        }
    }
}
