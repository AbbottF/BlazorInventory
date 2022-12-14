using System.Net.Http.Json;

namespace KBO_Inventory_Update.InventoryDashData
{
    public class InventoryDashDataService
    {
        private readonly HttpClient http;

        public InventoryDashDataService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<ResultInvType[]?> GetTable1()
        {
            using HttpResponseMessage response = http.GetAsync("https://excel2json.io/api/share/7966e682-e07d-4b37-e679-08dab79fa5b4").Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ResultInvType[]>().ConfigureAwait(false);
            }

            return null;
        }
    }
}