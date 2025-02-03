using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Loghid.Models;
using Loghid.Data;

namespace Loghid.Services
{
    public class ParametersService
    {
        private readonly LoghidDbContext _context;

        public ParametersService(LoghidDbContext context)
        {
            _context = context;
        }

        public async Task<List<Water>> GetWaterDataAsync()
        {
            return await _context.Water.ToListAsync();
        }

        public async Task<List<Methane>> GetMethaneDataAsync()
        {
            return await _context.Methane.ToListAsync();
        }

        public async Task<List<NonCH4Hydrocarbons>> GetNonCH4HydrocarbonsDataAsync()
        {
            return await _context.NonCH4Hydrocarbons.ToListAsync();
        }

        public async Task<List<Oxygen>> GetOxygenDataAsync()
        {
            return await _context.Oxygen.ToListAsync();
        }

        public async Task<List<Helium>> GetHeliumDataAsync()
        {
            return await _context.Helium.ToListAsync();
        }

        public async Task<List<Nitrogen>> GetNitrogenDataAsync()
        {
            return await _context.Nitrogen.ToListAsync();
        }

        public async Task<List<Argon>> GetArgonDataAsync()
        {
            return await _context.Argon.ToListAsync();
        }

        public async Task<List<CarbonDioxide>> GetCarbonDioxideDataAsync()
        {
            return await _context.CarbonDioxide.ToListAsync();
        }

        public async Task<List<CarbonMonoxide>> GetCarbonMonoxideDataAsync()
        {
            return await _context.CarbonMonoxide.ToListAsync();
        }

        public async Task<List<SulphurCompounds>> GetSulphurCompoundsDataAsync()
        {
            return await _context.SulphurCompounds.ToListAsync();
        }

        public async Task<List<Formaldehyde>> GetFormaldehydeDataAsync()
        {
            return await _context.Formaldehyde.ToListAsync();
        }

        public async Task<List<FormicAcid>> GetFormicAcidDataAsync()
        {
            return await _context.FormicAcid.ToListAsync();
        }

        public async Task<List<Ammonia>> GetAmmoniaDataAsync()
        {
            return await _context.Ammonia.ToListAsync();
        }

        public async Task<List<HalogenatedCompounds>> GetHalogenatedCompoundsDataAsync()
        {
            return await _context.HalogenatedCompounds.ToListAsync();
        }

        public async Task<List<Hydrocarbons>> GetHydrocarbonsDataAsync()
        {
            return await _context.Hydrocarbons.ToListAsync();
        }
    }
}