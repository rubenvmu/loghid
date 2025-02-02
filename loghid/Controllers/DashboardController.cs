// Controllers/DashboardController.cs
using loghid.Services;
using loghid.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace loghid.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ParametersService _parametersService;

        public DashboardController(ParametersService parametersService)
        {
            _parametersService = parametersService;
        }

        public async Task<IActionResult> Index()
        {
            var idealParams = _parametersService.GetIdealParameters();
            var contaminantParams = await _parametersService.GetContaminantParametersAsync();
            
            ViewBag.IdealParameters = idealParams;
            ViewBag.ContaminantParameters = contaminantParams;
            
            return View();
        }

        // Acción para mostrar el formulario de creación
        [HttpGet]
        public IActionResult CreateContaminantParameter()
        {
            return View();
        }

        // Acción para procesar la creación de un nuevo ContaminantParameter
        [HttpPost]
        public async Task<IActionResult> CreateContaminantParameter(ContaminantParameter parameter)
        {
            if (!ModelState.IsValid)
            {
                // Retorna la vista con errores de validación si los datos no son correctos
                return View(parameter);
            }

            // Se añade el registro a la base de datos mediante la capa de servicios
            await _parametersService.AddContaminantParameterAsync(parameter);

            // Tras la inserción exitosa, se redirige a la vista principal
            return RedirectToAction("Index");
        }
    }
}
