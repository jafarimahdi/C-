using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PhoneAiTechAdvisor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public string PhoneName1 { get; set; }

        [BindProperty]
        public string PhoneName2 { get; set; }
        

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnPost()
        {
            _logger.LogInformation($"hey, here is your phone: {PhoneName1},  {PhoneName2} ");
            return RedirectToPage("/Compare", new {PhoneName1, PhoneName2} );
        }
    }
}