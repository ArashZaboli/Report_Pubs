using System;
using System.Collections.Generic;

namespace Report_Pubs.Models;

public partial class BookType
{
    public string BookType1 { get; set; } = null!;

    public string Title { get; set; } = null!;

    public decimal? Price { get; set; }

    public string? Publisher { get; set; }

    public DateTime ReleaseDate { get; set; }
}
