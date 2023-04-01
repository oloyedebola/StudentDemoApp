using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdminDemo.Pages.Student
{
    public class DashboardModel : PageModel
    {
        private readonly ILogger<DashboardModel> _logger;
        public DashboardModel(ILogger<DashboardModel> logger)
        {
            _logger = logger;
        }


        public IActionResult OnGet()
        {
            _logger.LogDebug("Student Dashboard");

            return Page();
        }
    }
}
