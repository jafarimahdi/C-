using Microsoft.AspNetCore.Mvc;
using PhoneAiTechAdvisor.Models;
using Refit;

namespace PhoneAiTechAdvisor.Services
{
    public interface IAiApiClient
    {
        [Get("/{phoneName}")]
        Task<PhoneAiModel> GetPhoneTechSpecAsync(string phoneName);
    }
}
