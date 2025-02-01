using loghid.Data;
using loghid.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace loghid.Services
{
    public class ParametersService
    {
        private readonly ApplicationDbContext _context;

        public ParametersService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<IdealParameter>> GetIdealParametersAsync()
        {
            return await _context.IdealParameters.ToListAsync();
        }

        public async Task<List<ContaminantParameter>> GetContaminantParametersAsync()
        {
            return await _context.ContaminantParameters.ToListAsync();
        }
    }
}