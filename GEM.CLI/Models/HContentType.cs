using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HContentType
{
    public int TypeId { get; set; }

    public string TypeTitle { get; set; } = null!;

    public string TypeAlias { get; set; } = null!;

    public string Table { get; set; } = null!;

    public string Rules { get; set; } = null!;

    public string FieldMappings { get; set; } = null!;

    public string Router { get; set; } = null!;

    /// <summary>
    /// JSON string for com_contenthistory options
    /// </summary>
    public string? ContentHistoryOptions { get; set; }
}
