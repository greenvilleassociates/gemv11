using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HFinderFilter
{
    public int FilterId { get; set; }

    public string Title { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public short State { get; set; }

    public DateTime Created { get; set; }

    public int CreatedBy { get; set; }

    public string CreatedByAlias { get; set; } = null!;

    public DateTime Modified { get; set; }

    public int ModifiedBy { get; set; }

    public int CheckedOut { get; set; }

    public DateTime CheckedOutTime { get; set; }

    public int MapCount { get; set; }

    public string Data { get; set; } = null!;

    public string? Params { get; set; }
}
