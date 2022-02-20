using WiredBrainCoffeeAdmin.Data.Models;

namespace WiredBrainCoffeeAdmin.Data
{
    public interface ITicketService
    {
        Task<List<HelpTicket>> GetTickets();
        Task<string> PostTicket(HelpTicket ticket);
    }

    public class TicketService : ITicketService
    {
        private readonly HttpClient _httpClient;

        public TicketService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<HelpTicket>> GetTickets()
        {
            return await _httpClient.GetFromJsonAsync<List<HelpTicket>>("/api/tickets");
        }

        public async Task<string> PostTicket(HelpTicket ticket)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/ticket", ticket);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
