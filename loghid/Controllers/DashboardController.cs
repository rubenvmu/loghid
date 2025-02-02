using loghid.Services;
using loghid.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace loghid.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ParametersService _parametersService;

        // Constructor para inyectar el servicio de parámetros
        public DashboardController(ParametersService parametersService)
        {
            _parametersService = parametersService;
        }

        // Método asincrónico para cargar los parámetros
        public async Task<IActionResult> Index()
{
    var idealParams = await _parametersService.GetIdealParametersAsync() ?? new List<IdealParameter>();
    var contaminantParams = await _parametersService.GetContaminantParametersAsync() ?? new List<ContaminantParameter>();

    // Verificar que los datos están llegando correctamente
    Console.WriteLine($"Ideal Parameters Count: {idealParams.Count}");
    Console.WriteLine($"Contaminant Parameters Count: {contaminantParams.Count}");

    ViewBag.IdealParameters = idealParams;
    ViewBag.ContaminantParameters = contaminantParams;
    
    return View();
}

        // Acción para mostrar el formulario de creación del parámetro contaminante
        [HttpGet]
        public IActionResult CreateContaminantParameter()
        {
            return View();
        }

        // Acción para procesar el formulario de creación de un nuevo ContaminantParameter
        [HttpPost]
        public async Task<IActionResult> CreateContaminantParameter(ContaminantParameter parameter)
        {
            // Comprobar si el modelo es válido antes de realizar la operación
            if (!ModelState.IsValid)
            {
                return View(parameter); // Si no es válido, vuelve a la vista con los errores
            }

            // Añadir el parámetro contaminante a la base de datos mediante el servicio
            await _parametersService.AddContaminantParameterAsync(parameter);

            // Tras la inserción exitosa, redirigir a la vista principal
            return RedirectToAction("Index");
        }
    }
}