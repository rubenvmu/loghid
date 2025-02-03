using loghid.Models;
using Loghid.Services;
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

    }
}