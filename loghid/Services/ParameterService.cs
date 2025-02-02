// Services/ParametersService.cs
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

        // Método para insertar un nuevo registro de ContaminantParameter
        public async Task AddContaminantParameterAsync(ContaminantParameter parameter)
        {
            _context.ContaminantParameters.Add(parameter);
            await _context.SaveChangesAsync();
        }

        internal dynamic GetIdealParameters()
        {
            throw new NotImplementedException();
        }
    }
}
