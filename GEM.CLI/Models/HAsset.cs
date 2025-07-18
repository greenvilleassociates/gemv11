using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HAsset
{
    /// <summary>
    /// Primary Key
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Nested set parent.
    /// </summary>
    public long ParentId { get; set; }

    /// <summary>
    /// Nested set lft.
    /// </summary>
    public long Lft { get; set; }

    /// <summary>
    /// Nested set rgt.
    /// </summary>
    public long Rgt { get; set; }

    /// <summary>
    /// The cached level in the nested tree.
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// The unique name for the asset.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// The descriptive title for the asset.
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// JSON encoded access control.
    /// </summary>
    public string Rules { get; set; } = null!;
}
