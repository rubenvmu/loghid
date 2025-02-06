using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;

public interface ISubstanceSearchService
{
    Task<IEnumerable<Substance>> SearchSubstancesAsync(string searchTerm);
    Task<IEnumerable<Substance>> GetAllSubstancesAsync();
}

public class SubstanceSearchService : ISubstanceSearchService
{
    private readonly LoghidDbContext _context;

    public SubstanceSearchService(LoghidDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Substance>> SearchSubstancesAsync(string searchTerm)
    {
        if (string.IsNullOrWhiteSpace(searchTerm))
            return await GetAllSubstancesAsync();

        return await _context.Substances
            .Where(s => EF.Functions.Like(s.SubstanceName, $"{searchTerm}%")) // Más eficiente que ToLower()
            .ToListAsync();
    }

    public async Task<IEnumerable<Substance>> GetAllSubstancesAsync()
    {
        return await _context.Substances.ToListAsync();
    }
}