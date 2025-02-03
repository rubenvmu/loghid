using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace loghid.Pages
{
    public class IncidentsModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public IncidentsModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
