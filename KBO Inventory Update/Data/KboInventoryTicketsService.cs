using System.Net.Http.Json;
using KBO_Inventory_Update.Models;

namespace KBO_Inventory_Update.Data
{
    public class KboInventoryTicketsService
    {
        private readonly HttpClient http;

        public KboInventoryTicketsService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<KboInventoryTicket[]?> GetTable1()
        {
            using HttpResponseMessage response = http.GetAsync("https://excel2json.io/api/share/5c5448bf-c276-4113-e674-08dab79fa5b4").Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<KboInventoryTicket[]>().ConfigureAwait(false);
            }

            return null;
        }
    }
}