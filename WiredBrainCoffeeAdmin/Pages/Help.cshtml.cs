using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.Design;
using WiredBrainCoffeeAdmin.Data;
using WiredBrainCoffeeAdmin.Data.Models;

namespace WiredBrainCoffeeAdmin.Pages
{
    public class HelpModel : PageModel
    {
        private readonly ITicketService _client;

        public List<HelpTicket> HelpTickets { get; set; }

        [BindProperty]
        public HelpTicket Ticket { get; set; }

        public string ResponseMessage { get; set; }

        public async Task<IActionResult> OnGet()
        {
            HelpTickets = await _client.GetTickets();

            return Page();
        }

        public HelpModel(ITicketService client)
        {
            _client = client;
        }

        public async Task<IActionResult> OnPost()
        {
            ResponseMessage = await _client.PostTicket(Ticket);
            HelpTickets = await _client.GetTickets();
            return Page();
        }
    }
}
