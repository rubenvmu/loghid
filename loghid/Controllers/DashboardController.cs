using loghid.Services;
using Microsoft.AspNetCore.Mvc;

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
            var idealParams = await _parametersService.GetIdealParametersAsync();
            var contaminantParams = await _parametersService.GetContaminantParametersAsync();
            
            ViewBag.IdealParameters = idealParams;
            ViewBag.ContaminantParameters = contaminantParams;
            
            return View();
        }
    }
}