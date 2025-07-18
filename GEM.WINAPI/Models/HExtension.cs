using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HExtension
{
    public int ExtensionId { get; set; }

    /// <summary>
    /// Parent package ID for extensions installed as a package.
    /// </summary>
    public long PackageId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Element { get; set; } = null!;

    public string Folder { get; set; } = null!;

    public short ClientId { get; set; }

    public short Enabled { get; set; }

    public long Access { get; set; }

    public short Protected { get; set; }

    public string ManifestCache { get; set; } = null!;

    public string Params { get; set; } = null!;

    public string CustomData { get; set; } = null!;

    public string SystemData { get; set; } = null!;

    public int CheckedOut { get; set; }

    public DateTime CheckedOutTime { get; set; }

    public long? Ordering { get; set; }

    public long? State { get; set; }
}
