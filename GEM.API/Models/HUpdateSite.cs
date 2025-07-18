using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

/// <summary>
/// Update Sites
/// </summary>
public partial class HUpdateSite
{
    public int UpdateSiteId { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string Location { get; set; } = null!;

    public long? Enabled { get; set; }

    public long? LastCheckTimestamp { get; set; }

    public string? ExtraQuery { get; set; }
}
