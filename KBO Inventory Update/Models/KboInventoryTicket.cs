using System;
using System.Collections.Generic;

namespace KBO_Inventory_Update.Models;

public partial class KboInventoryTicket
{
    public string Age { get; set; } = null!;

    public string Author { get; set; } = null!;

    public int AvaliableQuantity { get; set; }

    public string Binding { get; set; } = null!;

    public string Blowout { get; set; } = null!;

    public string? CalendarEvent { get; set; }

    public string Category { get; set; } = null!;

    public string? Category2 { get; set; }

    public string? Category3 { get; set; }
    public string Isbn { get; set; } = null!;

    public string? JsonData { get; set; }

    public decimal ListUsd { get; set; }

    public decimal NetUsd { get; set; }

    public decimal? OurSalesPrice { get; set; }

    public string Publisher { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string? Subject2 { get; set; }

    public string? Subject3 { get; set; }

    public string Title { get; set; } = null!;

    public bool IsCatChangedFlag { get; set; }

    public bool? IsNewFlag { get; set; }

    public bool IsPriceChangeFlag { get; set; }

    public bool IsPriorFlag { get; set; }

    public bool IsQtyChangedFlag { get; set; }

    public bool IsRemoveFlag { get; set; }

    public DateTime CreateDatetime { get; set; }

    public DateTime ProcessDatetime { get; set; }
}
