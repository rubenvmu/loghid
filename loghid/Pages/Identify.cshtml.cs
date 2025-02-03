using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace loghid.Pages
{
    public class IdentifyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public IdentifyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
