using loghid.Models;
using loghid.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace loghid.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ParametersService _parametersService;

        [BindProperty]
        public IdealParameter NewIdealParameter { get; set; } = new IdealParameter(); // Inicializado para evitar null

        [BindProperty]
        public ContaminantParameter NewContaminant { get; set; } = new ContaminantParameter(); // Inicializado para evitar null

        // Propiedades para las listas
        public List<IdealParameter> IdealParameters { get; set; } = new(); // Inicializado como lista vacía
        public List<ContaminantParameter> ContaminantParameters { get; set; } = new(); // Inicializado como lista vacía

        public IndexModel(ParametersService parametersService)
        {
            _parametersService = parametersService;
        }

        public async Task OnGetAsync() // Cargar datos al inicializar
        {
            // Asegurarse de que las listas no sean null
            IdealParameters = await _parametersService.GetIdealParametersAsync() ?? new List<IdealParameter>();
            ContaminantParameters = await _parametersService.GetContaminantParametersAsync() ?? new List<ContaminantParameter>();
        }

        public async Task<IActionResult> OnPostAddIdealParameterAsync()
        {
            if (!ModelState.IsValid) return Page();
            await _parametersService.AddIdealParameterAsync(NewIdealParameter);
            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostAddContaminantParameterAsync()
        {
            if (!ModelState.IsValid) return Page();
            await _parametersService.AddContaminantParameterAsync(NewContaminant);
            return RedirectToPage();
        }
    }
}