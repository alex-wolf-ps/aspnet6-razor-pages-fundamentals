using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.Design;
using WiredBrainCoffeeAdmin.Data;
using WiredBrainCoffeeAdmin.Data.Models;

namespace WiredBrainCoffeeAdmin.Pages
{
    public class HelpModel : PageModel
    {
        private readonly ITicketService ticketService;

        public List<HelpTicket> HelpTickets { get; set; }

        [BindProperty]
        public HelpTicket Ticket { get; set; }

        public string ResponseMessage { get; set; }

        public async Task<IActionResult> OnGet()
        {
            HelpTickets = await ticketService.GetTickets();

            return Page();
        }

        public HelpModel(ITicketService client)
        {
            ticketService = client;
        }

        public async Task<IActionResult> OnPost()
        {
            ResponseMessage = await ticketService.PostTicket(Ticket);

            HelpTickets = await ticketService.GetTickets();

            return Page();
        }
    }
}
