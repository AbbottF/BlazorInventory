//namespace KBO_Inventory_Update.Data.NewTitles; // Razor won't recognize third level namespace
namespace KBO_Inventory_Update.NewTitles;

public class KboInventoryTicket
{
    public string? ISBN { get; set; }
    public string? Title { get; set; }
    public string? Author { get; set; }
    public string? Publisher { get; set; }
    public string? Category { get; set; }
    public string? Subject { get; set; }
    public string? Binding { get; set; }
    public double? ListUSD { get; set; }
    public double? NetUSD { get; set; }
    public double? AvaliableQuantity { get; set; }
    public string? Blowout { get; set; }
    public string? Category2 { get; set; }
    public string? Category3 { get; set; }
    public string? Subject2 { get; set; }
    public string? Subject3 { get; set; }
    public string? Age { get; set; }
    public string? CalendarEvent { get; set; }
}
