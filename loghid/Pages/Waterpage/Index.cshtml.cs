using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

namespace loghid.Pages.Waterpage
{
    public class IndexModel : PageModel
    {
        private readonly Loghid.Data.LoghidDbContext _context;

        public IndexModel(Loghid.Data.LoghidDbContext context)
        {
            _context = context;
        }

        public IList<Substance> CombinedSubstances { get; set; } = new List<Substance>();

        public async Task OnGetAsync()
        {
            // Recuperar todas las sustancias de la base de datos
            CombinedSubstances = await _context.Substances.ToListAsync();
        }
    }
}