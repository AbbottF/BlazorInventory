using System.Text.Json;

namespace KBO_Inventory_Update.Financial
{
    public class FinancialService
    {
        private readonly IWebHostEnvironment _env;

        public FinancialService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public async Task<BoxOfficeRevenueType[]?> GetBoxOfficeRevenue()
        {
            var options = new JsonSerializerOptions(new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            var data = File.ReadAllText(_env.WebRootPath + "/static-data/financial-box-office-revenue.json");
            return await Task.FromResult(JsonSerializer.Deserialize<BoxOfficeRevenueType[]>(data, options));
        }
    }
}