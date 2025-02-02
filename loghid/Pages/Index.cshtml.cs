using loghid.Models;
using loghid.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace loghid.Pages
{
    public class IndexModel(ParametersService parametersService) : PageModel
    {
        private readonly ParametersService _parametersService = parametersService;

        public required List<IdealParameter> IdealParameters { get; set; }
        public required List<ContaminantParameter> ContaminantParameters { get; set; }

        public async Task OnGetAsync()
        {
            IdealParameters = await _parametersService.GetIdealParametersAsync();
            ContaminantParameters = await _parametersService.GetContaminantParametersAsync();
        }
    }
}