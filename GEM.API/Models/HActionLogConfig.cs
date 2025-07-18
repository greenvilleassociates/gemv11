using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HActionLogConfig
{
    public int Id { get; set; }

    public string TypeTitle { get; set; } = null!;

    public string TypeAlias { get; set; } = null!;

    public string? IdHolder { get; set; }

    public string? TitleHolder { get; set; }

    public string? TableName { get; set; }

    public string? TextPrefix { get; set; }
}
