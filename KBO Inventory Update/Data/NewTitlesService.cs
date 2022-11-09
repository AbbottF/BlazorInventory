using System.Net.Http.Json;

namespace KBO_Inventory_Update.NewTitles
{
    public class NewTitlesService
    {
        private readonly HttpClient http;

        public NewTitlesService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<Table1Type[]?> GetTable1()
        {
            using HttpResponseMessage response = http.GetAsync("https://excel2json.io/api/share/5c5448bf-c276-4113-e674-08dab79fa5b4").Result;
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Table1Type[]>().ConfigureAwait(false);
            }

            return null;
        }
    }
}