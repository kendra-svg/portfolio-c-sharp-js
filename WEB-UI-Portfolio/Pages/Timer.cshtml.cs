using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WEB_UI_Portfolio.Pages
{
    public class TimerModel : PageModel
    {
        private readonly ILogger<TimerModel> _logger;

        public TimerModel(ILogger<TimerModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
