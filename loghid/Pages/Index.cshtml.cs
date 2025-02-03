using Loghid.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Loghid.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loghid.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ParametersService _parametersService;

        public IEnumerable<SubstanceDisplayModel> Substances { get; set; } = new List<SubstanceDisplayModel>();

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
            Substances = new List<SubstanceDisplayModel>
            {
                new SubstanceDisplayModel("Water", (await _parametersService.GetWaterDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Methane", (await _parametersService.GetMethaneDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Non-CH4 Hydrocarbons", (await _parametersService.GetNonCH4HydrocarbonsDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Oxygen", (await _parametersService.GetOxygenDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Helium", (await _parametersService.GetHeliumDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Nitrogen", (await _parametersService.GetNitrogenDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Argon", (await _parametersService.GetArgonDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Carbon Dioxide", (await _parametersService.GetCarbonDioxideDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Carbon Monoxide", (await _parametersService.GetCarbonMonoxideDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Sulphur Compounds", (await _parametersService.GetSulphurCompoundsDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Formaldehyde", (await _parametersService.GetFormaldehydeDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Formic Acid", (await _parametersService.GetFormicAcidDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Ammonia", (await _parametersService.GetAmmoniaDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Halogenated Compounds", (await _parametersService.GetHalogenatedCompoundsDataAsync()).Cast<ISubstanceData>()),
                new SubstanceDisplayModel("Hydrocarbons", (await _parametersService.GetHydrocarbonsDataAsync()).Cast<ISubstanceData>())
            };
        }
    }

    public class SubstanceDisplayModel
    {
        public string Name { get; set; }
        public IEnumerable<ISubstanceData> Data { get; set; }

        public SubstanceDisplayModel(string name, IEnumerable<ISubstanceData> data)
        {
            Name = name;
            Data = data ?? Enumerable.Empty<ISubstanceData>();
        }
    }

    public interface ISubstanceData
    {
        int Id { get; set; }
        double IsoThreshold { get; set; }
        string Probability { get; set; }
    }
}