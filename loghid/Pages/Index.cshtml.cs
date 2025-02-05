using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;


namespace Loghid.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LoghidDbContext _context;

        public IndexModel(LoghidDbContext context)
        {
            _context = context;
        }

        public List<Substance> CombinedSubstances { get; set; } = new List<Substance>();

        public async Task OnGetAsync()
{
    // Combina todas las sustancias en una sola lista de tipo Substance
    CombinedSubstances = await _context.Water
        .Select(w => new Substance
        {
            Id = w.Id,
            SubstanceName = "Water",
            IsoThreshold = w.IsoThreshold,
            MeasurementMethod = w.MeasurementMethod,
            MeasuredRange = w.MeasuredRange,
            Probability = w.Probability
        })
        .ToListAsync();

    CombinedSubstances.AddRange(await _context.Methane
        .Select(m => new Substance
        {
            Id = m.Id,
            SubstanceName = "Methane",
            IsoThreshold = m.IsoThreshold,
            MeasurementMethod = m.MeasurementMethod,
            MeasuredRange = m.MeasuredRange,
            Probability = m.Probability
        })
        .ToListAsync());

    CombinedSubstances.AddRange(await _context.NonCH4Hydrocarbons
        .Select(n => new Substance
        {
            Id = n.Id,
            SubstanceName = "NonCH4Hydrocarbons",
            IsoThreshold = n.IsoThreshold,
            MeasurementMethod = n.MeasurementMethod,
            MeasuredRange = n.MeasuredRange,
            Probability = n.Probability
        })
        .ToListAsync());

    CombinedSubstances.AddRange(await _context.Oxygen
        .Select(o => new Substance
        {
            Id = o.Id,
            SubstanceName = "Oxygen",
            IsoThreshold = o.IsoThreshold,
            MeasurementMethod = o.MeasurementMethod,
            MeasuredRange = o.MeasuredRange,
            Probability = o.Probability
        })
        .ToListAsync());

    CombinedSubstances.AddRange(await _context.Helium
        .Select(h => new Substance
        {
            Id = h.Id,
            SubstanceName = "Helium",
            IsoThreshold = h.IsoThreshold,
            MeasurementMethod = h.MeasurementMethod,
            MeasuredRange = h.MeasuredRange,
            Probability = h.Probability
        })
        .ToListAsync());

    CombinedSubstances.AddRange(await _context.Nitrogen
        .Select(n => new Substance
        {
            Id = n.Id,
            SubstanceName = "Nitrogen",
            IsoThreshold = n.IsoThreshold,
            MeasurementMethod = n.MeasurementMethod,
            MeasuredRange = n.MeasuredRange,
            Probability = n.Probability
        })
        .ToListAsync());

    CombinedSubstances.AddRange(await _context.Argon
        .Select(a => new Substance
        {
            Id = a.Id,
            SubstanceName = "Argon",
            IsoThreshold = a.IsoThreshold,
            MeasurementMethod = a.MeasurementMethod,
            MeasuredRange = a.MeasuredRange,
            Probability = a.Probability
        })
        .ToListAsync());

    CombinedSubstances.AddRange(await _context.CarbonDioxide
        .Select(c => new Substance
        {
            Id = c.Id,
            SubstanceName = "CarbonDioxide",
            IsoThreshold = c.IsoThreshold,
            MeasurementMethod = c.MeasurementMethod,
            MeasuredRange = c.MeasuredRange,
            Probability = c.Probability
        })
        .ToListAsync());

    CombinedSubstances.AddRange(await _context.CarbonMonoxide
        .Select(c => new Substance
        {
            Id = c.Id,
            SubstanceName = "CarbonMonoxide",
            IsoThreshold = c.IsoThreshold,
            MeasurementMethod = c.MeasurementMethod,
            MeasuredRange = c.MeasuredRange,
            Probability = c.Probability
        })
        .ToListAsync());

    CombinedSubstances.AddRange(await _context.SulphurCompounds
        .Select(s => new Substance
        {
            Id = s.Id,
            SubstanceName = "SulphurCompounds",
            IsoThreshold = s.IsoThreshold,
            MeasurementMethod = s.MeasurementMethod,
            MeasuredRange = s.MeasuredRange,
            Probability = s.Probability
        })
        .ToListAsync());

    CombinedSubstances.AddRange(await _context.Formaldehyde
        .Select(f => new Substance
        {
            Id = f.Id,
            SubstanceName = "Formaldehyde",
            IsoThreshold = f.IsoThreshold,
            MeasurementMethod = f.MeasurementMethod,
            MeasuredRange = f.MeasuredRange,
            Probability = f.Probability
        })
        .ToListAsync());

    CombinedSubstances.AddRange(await _context.FormicAcid
        .Select(f => new Substance
        {
            Id = f.Id,
            SubstanceName = "FormicAcid",
            IsoThreshold = f.IsoThreshold,
            MeasurementMethod = f.MeasurementMethod,
            MeasuredRange = f.MeasuredRange,
            Probability = f.Probability
        })
        .ToListAsync());

    CombinedSubstances.AddRange(await _context.Ammonia
        .Select(a => new Substance
        {
            Id = a.Id,
            SubstanceName = "Ammonia",
            IsoThreshold = a.IsoThreshold,
            MeasurementMethod = a.MeasurementMethod,
            MeasuredRange = a.MeasuredRange,
            Probability = a.Probability
        })
        .ToListAsync());

    CombinedSubstances.AddRange(await _context.HalogenatedCompounds
        .Select(h => new Substance
        {
            Id = h.Id,
            SubstanceName = "HalogenatedCompounds",
            IsoThreshold = h.IsoThreshold,
            MeasurementMethod = h.MeasurementMethod,
            MeasuredRange = h.MeasuredRange,
            Probability = h.Probability
        })
        .ToListAsync());

    CombinedSubstances.AddRange(await _context.Hydrocarbons
        .Select(h => new Substance
        {
            Id = h.Id,
            SubstanceName = "Hydrocarbons",
            IsoThreshold = h.IsoThreshold,
            MeasurementMethod = h.MeasurementMethod,
            MeasuredRange = h.MeasuredRange,
            Probability = h.Probability
        })
        .ToListAsync());

    // Ordena la lista de sustancias por nombre
    CombinedSubstances = CombinedSubstances.OrderBy(s => s.SubstanceName).ToList();

    }
}
}