using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

/// <summary>
/// Available Updates
/// </summary>
public partial class HUpdate
{
    public int UpdateId { get; set; }

    public long? UpdateSiteId { get; set; }

    public long? ExtensionId { get; set; }

    public string? Name { get; set; }

    public string Description { get; set; } = null!;

    public string? Element { get; set; }

    public string? Type { get; set; }

    public string? Folder { get; set; }

    public short? ClientId { get; set; }

    public string? Version { get; set; }

    public string Data { get; set; } = null!;

    public string Detailsurl { get; set; } = null!;

    public string Infourl { get; set; } = null!;

    public string? ExtraQuery { get; set; }
}
