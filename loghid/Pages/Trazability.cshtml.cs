using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace loghid.Pages
{
    public class TrazabilityModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public TrazabilityModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
