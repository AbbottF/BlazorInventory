//namespace KBO_Inventory_Update.Data.Financial; // Razor won't recognize third level namespace
namespace KBO_Inventory_Update.Financial;

public class BoxOfficeRevenueType
{
    public string? Franchise { get; set; }
    public double? TotalWorldBoxOfficeRevenue { get; set; }
    public double? HighestGrossingMovieInSeries { get; set; }
}
