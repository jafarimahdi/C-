using Microsoft.AspNetCore.Mvc.RazorPages;
using PhoneAiTechAdvisor.Models;
using PhoneAiTechAdvisor.Services;

namespace PhoneAiTechAdvisor.Pages
{
    public class CompareModel : PageModel
    {
        private readonly ILogger<CompareModel> logger;
        private readonly IAiApiClient aiApiClient;

        public CompareModel(ILogger<CompareModel> logger, IAiApiClient aiApiClient)
        {
            this.logger = logger;
            this.aiApiClient = aiApiClient;
        }

        public List<PhoneAiModel> Phones { get; set; } = new List<PhoneAiModel>();

        public async Task OnGetAsync(string phoneName1, string phoneName2)
        {
            logger.LogInformation($"Compare {phoneName1} and {phoneName2}");
            var phone1 = await aiApiClient.GetPhoneTechSpecAsync(phoneName1);
            var phone2 = await aiApiClient.GetPhoneTechSpecAsync(phoneName2);

            Phones.Add(phone1);
            Phones.Add(phone2);
        }
    }
}
