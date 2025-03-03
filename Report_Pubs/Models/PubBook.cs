using System;
using System.Collections.Generic;

namespace Report_Pubs.Models;

public partial class PubBook
{
    public string Id { get; set; } = null!;

    public string? PublisherName { get; set; }

    public string Title { get; set; } = null!;

    public decimal? Price { get; set; }

    public DateTime RealeseDate { get; set; }
}
