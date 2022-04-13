using WiredBrainCoffeeAdmin.Data.Models;

namespace WiredBrainCoffeeAdmin.Data
{
    public class TicketService : ITicketService
    {
        private HttpClient client;

        public TicketService(HttpClient client)
        {
            this.client = client;
        }

        public async Task<string> Add(HelpTicket ticket)
        {
            var response = await client.PostAsJsonAsync<HelpTicket>("/api/ticket", ticket);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<List<HelpTicket>> GetAll()
        {
            return await client.GetFromJsonAsync<List<HelpTicket>>("/api/tickets");
        }
    }
}
