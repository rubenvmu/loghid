using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace loghid.Pages
{
    public class NewsModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public NewsModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
