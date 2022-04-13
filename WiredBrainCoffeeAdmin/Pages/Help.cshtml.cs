using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.Design;
using WiredBrainCoffeeAdmin.Data;
using WiredBrainCoffeeAdmin.Data.Models;

namespace WiredBrainCoffeeAdmin.Pages
{
    public class HelpModel : PageModel
    {
        [BindProperty]
        public HelpTicket NewTicket { get; set; }

        public List<HelpTicket> HelpTickets { get; set; }    

        public string ResponseMessage { get; set; }

        private ITicketService ticketService;

        public HelpModel(ITicketService ticketService)
        {
            this.ticketService = ticketService;
        }

        public async Task<IActionResult> OnGet()
        {
            HelpTickets = await ticketService.GetAll();
            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            ResponseMessage = await ticketService.Add(NewTicket);
            HelpTickets = await ticketService.GetAll();
            return Page();
        }
    }
}
