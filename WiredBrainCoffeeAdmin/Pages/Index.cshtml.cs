using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Text;
using System.Text.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using WiredBrainCoffeeAdmin.Data.Models;

namespace WiredBrainCoffeeAdmin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory factory;

        public IDictionary<string, string> OrderStats { get; set; }

        public List<SurveyItem> SurveyResults { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpFactory)
        {
            _logger = logger;
            this.factory = httpFactory;
        }

        public async Task<IActionResult> OnGet()
        {
            var client = this.factory.CreateClient();
            var response = await client
                .GetAsync("https://wiredbraincoffeeadmin.azurewebsites.net/api/orderStats");

            var responseData = await response.Content.ReadAsStringAsync();
            OrderStats = JsonSerializer.Deserialize<IDictionary<string, string>>(responseData);

            var rawJson = System.IO.File
                .ReadAllText("wwwroot/sampledata/survey.json");

            SurveyResults = JsonSerializer.Deserialize<List<SurveyItem>>(rawJson);

            return Page();
        }
    }
}