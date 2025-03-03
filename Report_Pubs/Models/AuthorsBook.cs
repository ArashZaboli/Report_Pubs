using System;
using System.Collections.Generic;

namespace Report_Pubs.Models;

public partial class AuthorsBook
{
    public long? Id { get; set; }

    public string FullName { get; set; } = null!;

    public string Title { get; set; } = null!;

    public decimal? Price { get; set; }

    public string Type { get; set; } = null!;

    public DateTime RealeseDate { get; set; }
}
