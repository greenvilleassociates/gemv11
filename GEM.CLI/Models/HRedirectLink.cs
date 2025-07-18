using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HRedirectLink
{
    public int Id { get; set; }

    public string OldUrl { get; set; } = null!;

    public string? NewUrl { get; set; }

    public string Referer { get; set; } = null!;

    public string Comment { get; set; } = null!;

    public long Hits { get; set; }

    public short Published { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int Header { get; set; }
}
