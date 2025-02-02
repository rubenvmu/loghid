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

        // Constructor para inyectar el contexto de base de datos
        public ParametersService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Obtener los parámetros ideales de forma asincrónica
        public async Task<List<IdealParameter>> GetIdealParametersAsync()
        {
            return await _context.IdealParameters.ToListAsync();
        }

        // Obtener los parámetros contaminantes de forma asincrónica
        public async Task<List<ContaminantParameter>> GetContaminantParametersAsync()
        {
            return await _context.ContaminantParameters.ToListAsync();
        }

        // Agregar un nuevo parámetro ideal a la base de datos de forma asincrónica
        public async Task AddIdealParameterAsync(IdealParameter parameter)
        {
            _context.IdealParameters.Add(parameter);  // Añadir el nuevo parámetro
            await _context.SaveChangesAsync();  // Guardar cambios en la base de datos
        }

        // Agregar un nuevo parámetro contaminante a la base de datos de forma asincrónica
        public async Task AddContaminantParameterAsync(ContaminantParameter parameter)
        {
            _context.ContaminantParameters.Add(parameter);  // Añadir el nuevo parámetro
            await _context.SaveChangesAsync();  // Guardar cambios en la base de datos
        }
    }
}