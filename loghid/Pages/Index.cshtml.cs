using loghid.Models;
using loghid.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace loghid.Pages
{
    public class IndexModel(ParametersService parametersService) : PageModel
    {
        private readonly ParametersService _parametersService = parametersService;

        // Propiedades para mostrar los datos existentes
        public required List<IdealParameter> IdealParameters { get; set; }
        public required List<ContaminantParameter> ContaminantParameters { get; set; }

        // Propiedad para la inserción manual de un nuevo contaminante
        [BindProperty]
        public required ContaminantParameter NewContaminant { get; set; }

        [BindProperty]
        public required ContaminantParameter NewIdealParameter { get; set; }

        // Método GET para cargar los parámetros
        public async Task OnGetAsync()
        {
            IdealParameters = await _parametersService.GetIdealParametersAsync();
            ContaminantParameters = await _parametersService.GetContaminantParametersAsync();
        }

        // Método POST para procesar la inserción del nuevo contaminante
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                // En caso de error de validación, se recargan los parámetros para mostrarlos nuevamente
                IdealParameters = await _parametersService.GetIdealParametersAsync();
                ContaminantParameters = await _parametersService.GetContaminantParametersAsync();
                return Page();
            }

            // Inserta el nuevo contaminante en la base de datos a través del servicio
            await _parametersService.AddContaminantParameterAsync(NewContaminant);
            // Redirige a la misma página para mostrar los datos actualizados
            return RedirectToPage();
        }
    }
}

