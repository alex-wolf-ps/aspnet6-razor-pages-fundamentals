using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Text;
using System.Text.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace WiredBrainCoffeeAdmin.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _client;

        public List<SurveyItem> SurveyItems { get; set; } = new List<SurveyItem>();
        
        [BindProperty]
        public string HelpText { get; set; }

        public string HelpResponse { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory client)
        {
            _logger = logger;
            _client = client;
        }

        public void OnGet()
        {
            string text = System.IO.File.ReadAllText("wwwroot/SampleData/survey.json");
            SurveyItems = JsonSerializer.Deserialize<List<SurveyItem>>(text);
        }

        

        public class SurveyItem {
            public string Question { get; set; }
            public string Answer { get; set; }
        }
    }
}