using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HCategory
{
    public int Id { get; set; }

    /// <summary>
    /// FK to the #__assets table.
    /// </summary>
    public long AssetId { get; set; }

    public int ParentId { get; set; }

    public long Lft { get; set; }

    public long Rgt { get; set; }

    public int Level { get; set; }

    public string Path { get; set; } = null!;

    public string Extension { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string Description { get; set; } = null!;

    public short Published { get; set; }

    public long CheckedOut { get; set; }

    public DateTime CheckedOutTime { get; set; }

    public long Access { get; set; }

    public string Params { get; set; } = null!;

    /// <summary>
    /// The meta description for the page.
    /// </summary>
    public string Metadesc { get; set; } = null!;

    /// <summary>
    /// The meta keywords for the page.
    /// </summary>
    public string Metakey { get; set; } = null!;

    /// <summary>
    /// JSON encoded metadata properties.
    /// </summary>
    public string Metadata { get; set; } = null!;

    public int CreatedUserId { get; set; }

    public DateTime CreatedTime { get; set; }

    public int ModifiedUserId { get; set; }

    public DateTime ModifiedTime { get; set; }

    public int Hits { get; set; }

    public string Language { get; set; } = null!;

    public long Version { get; set; }
}
