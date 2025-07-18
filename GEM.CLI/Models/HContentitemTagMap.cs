using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HContentitemTagMap
{
    public string TypeAlias { get; set; } = null!;

    /// <summary>
    /// PK from the core content table
    /// </summary>
    public int CoreContentId { get; set; }

    /// <summary>
    /// PK from the content type table
    /// </summary>
    public int ContentItemId { get; set; }

    /// <summary>
    /// PK from the tag table
    /// </summary>
    public int TagId { get; set; }

    /// <summary>
    /// Date of most recent save for this tag-item
    /// </summary>
    public DateTime TagDate { get; set; }

    /// <summary>
    /// PK from the content_type table
    /// </summary>
    public int TypeId { get; set; }
}
