using Microsoft.AspNetCore.Mvc;
using Loghid.Models;
using Loghid.Data;  // Asegúrate de que tu contexto de base de datos esté configurado correctamente

namespace Loghid.Controllers
{
    public class DashboardController : Controller
    {
        public readonly LoghidDbContext _context;

        public DashboardController(LoghidDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Recuperar todos los modelos (si lo deseas, puedes incluir un filtro o limitación de los resultados)
            var waterData = _context.Water.ToList();
            var methaneData = _context.Methane.ToList();
            var nonCH4HydrocarbonsData = _context.NonCH4Hydrocarbons.ToList();
            var oxygenData = _context.Oxygen.ToList();
            var heliumData = _context.Helium.ToList();
            var nitrogenData = _context.Nitrogen.ToList();
            var argonData = _context.Argon.ToList();
            var carbonDioxideData = _context.CarbonDioxide.ToList();
            var carbonMonoxideData = _context.CarbonMonoxide.ToList();
            var sulphurCompoundsData = _context.SulphurCompounds.ToList();
            var formaldehydeData = _context.Formaldehyde.ToList();
            var formicAcidData = _context.FormicAcid.ToList();
            var ammoniaData = _context.Ammonia.ToList();
            var halogenatedCompoundsData = _context.HalogenatedCompounds.ToList();
            var hydrocarbonsData = _context.Hydrocarbons.ToList();

            // Pasar los datos a la vista
            var dashboardData = new
            {
                WaterData = waterData,
                MethaneData = methaneData,
                NonCH4HydrocarbonsData = nonCH4HydrocarbonsData,
                OxygenData = oxygenData,
                HeliumData = heliumData,
                NitrogenData = nitrogenData,
                ArgonData = argonData,
                CarbonDioxideData = carbonDioxideData,
                CarbonMonoxideData = carbonMonoxideData,
                SulphurCompoundsData = sulphurCompoundsData,
                FormaldehydeData = formaldehydeData,
                FormicAcidData = formicAcidData,
                AmmoniaData = ammoniaData,
                HalogenatedCompoundsData = halogenatedCompoundsData,
                HydrocarbonsData = hydrocarbonsData
            };

            return View(dashboardData);
        }
    }
}