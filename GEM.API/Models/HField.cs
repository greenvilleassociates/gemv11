using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HField
{
    public int Id { get; set; }

    public long AssetId { get; set; }

    public string Context { get; set; } = null!;

    public long GroupId { get; set; }

    public string Title { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Label { get; set; } = null!;

    public string? DefaultValue { get; set; }

    public string Type { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string Description { get; set; } = null!;

    public short State { get; set; }

    public short Required { get; set; }

    public int CheckedOut { get; set; }

    public DateTime CheckedOutTime { get; set; }

    public long Ordering { get; set; }

    public string Params { get; set; } = null!;

    public string Fieldparams { get; set; } = null!;

    public string Language { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public long CreatedUserId { get; set; }

    public DateTime ModifiedTime { get; set; }

    public long ModifiedBy { get; set; }

    public long Access { get; set; }
}
