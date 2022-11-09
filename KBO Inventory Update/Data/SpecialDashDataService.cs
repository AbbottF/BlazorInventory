using System.Net.Http.Json;

namespace KBO_Inventory_Update.SpecialDashData
{
    public class SpecialDashDataService
    {
        private readonly HttpClient http;

        public SpecialDashDataService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<Table1Type[]?> GetTable1()
        {
            using HttpResponseMessage response = http.GetAsync("https://excel2json.io/api/share/7966e682-e07d-4b37-e679-08dab79fa5b4").Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Table1Type[]>().ConfigureAwait(false);
            }

            return null;
        }
    }
}