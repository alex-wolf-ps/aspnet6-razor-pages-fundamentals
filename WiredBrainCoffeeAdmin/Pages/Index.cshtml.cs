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

        public List<SurveyItem> SurveyItems { get; set; } = new List<SurveyItem>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string text = System.IO.File.ReadAllText("wwwroot/SampleData/survey.json");
            SurveyItems = JsonSerializer.Deserialize<List<SurveyItem>>(text);
        }
    }
}