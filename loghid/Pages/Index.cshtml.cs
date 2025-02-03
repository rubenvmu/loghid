using Loghid.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Loghid.Models;

namespace Loghid.Pages // Namespace con casing correcto
{
    public class IndexModel : PageModel
    {
        private readonly ParametersService _parametersService;
        
        // Clase movida fuera del modelo
        public class SubstanceTable
        {
            public string Name { get; set; } = string.Empty;
            public IEnumerable<ISubstanceData> Data { get; set; } = Enumerable.Empty<ISubstanceData>();
        }

        // Propiedades simplificadas con inicialización directa
        public IEnumerable<Water> WaterData { get; set; } = new List<Water>();
        public IEnumerable<Methane> MethaneData { get; set; } = new List<Methane>();
        public IEnumerable<NonCH4Hydrocarbons> NonCH4HydrocarbonsData { get; set; } = new List<NonCH4Hydrocarbons>();
        public IEnumerable<Oxygen> OxygenData { get; set; } = new List<Oxygen>();
        public IEnumerable<Helium> HeliumData { get; set; } = new List<Helium>();
        public IEnumerable<Nitrogen> NitrogenData { get; set; } = new List<Nitrogen>();
        public IEnumerable<Argon> ArgonData { get; set; } = new List<Argon>();
        public IEnumerable<CarbonDioxide> CarbonDioxideData { get; set; } = new List<CarbonDioxide>();
        public IEnumerable<CarbonMonoxide> CarbonMonoxideData { get; set; } = new List<CarbonMonoxide>();
        public IEnumerable<SulphurCompounds> SulphurCompoundsData { get; set; } = new List<SulphurCompounds>();
        public IEnumerable<Formaldehyde> FormaldehydeData { get; set; } = new List<Formaldehyde>();
        public IEnumerable<FormicAcid> FormicAcidData { get; set; } = new List<FormicAcid>();
        public IEnumerable<Ammonia> AmmoniaData { get; set; } = new List<Ammonia>();
        public IEnumerable<HalogenatedCompounds> HalogenatedCompoundsData { get; set; } = new List<HalogenatedCompounds>();
        public IEnumerable<Hydrocarbons> HydrocarbonsData { get; set; } = new List<Hydrocarbons>();

        // ... Repetir para todas las propiedades restantes ...

        public IndexModel(ParametersService parametersService)
        {
            _parametersService = parametersService;
        }

        public async Task OnGetAsync()
        {
            await LoadAllDataAsync();
        }

        private async Task LoadAllDataAsync()
        {
            WaterData = await _parametersService.GetWaterDataAsync();
            MethaneData = await _parametersService.GetMethaneDataAsync();
            NonCH4HydrocarbonsData = await _parametersService.GetNonCH4HydrocarbonsDataAsync();
            OxygenData = await _parametersService.GetOxygenDataAsync();
            HeliumData = await _parametersService.GetHeliumDataAsync();
            NitrogenData = await _parametersService.GetNitrogenDataAsync();
            ArgonData = await _parametersService.GetArgonDataAsync();
            CarbonDioxideData = await _parametersService.GetCarbonDioxideDataAsync();
            CarbonMonoxideData = await _parametersService.GetCarbonMonoxideDataAsync();
            SulphurCompoundsData = await _parametersService.GetSulphurCompoundsDataAsync();
            FormaldehydeData = await _parametersService.GetFormaldehydeDataAsync();
            FormicAcidData = await _parametersService.GetFormicAcidDataAsync();
            AmmoniaData = await _parametersService.GetAmmoniaDataAsync();
            HalogenatedCompoundsData = await _parametersService.GetHalogenatedCompoundsDataAsync();
            HydrocarbonsData = await _parametersService.GetHydrocarbonsDataAsync();
        }
    }

    // Clase movida fuera del modelo para mejor acceso
    public class SubstanceTable
    {
        public string Name { get; set; } = string.Empty;
        public IEnumerable<ISubstanceData> Data { get; set; } = Enumerable.Empty<ISubstanceData>();
    }
}