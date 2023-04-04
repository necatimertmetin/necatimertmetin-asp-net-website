using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SUDMarin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPostEN()
        {
            return Redirect("~/?culture=en-US");
        }
        public IActionResult OnPostTR()
        {
           return Redirect("~/?culture=tr-TR");
        }
    }
}