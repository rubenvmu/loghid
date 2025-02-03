
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace loghid.Pages
{
    public class DashboardModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public DashboardModel(ILogger<PrivacyModel> logger)
        {


            _logger = logger;


        }

        public void OnGet()
        {
        }
    }

}
