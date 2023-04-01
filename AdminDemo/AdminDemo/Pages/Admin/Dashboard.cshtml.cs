using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdminDemo.Pages.Admin
{
    public class DashboardModel : PageModel
    {

        private readonly ILogger<DashboardModel> _logger;
        public DashboardModel(ILogger<DashboardModel> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            _logger.LogDebug("Admin Dashboard");

            return Page();
        }
    }
}
