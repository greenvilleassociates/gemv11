using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HModule
{
    public int Id { get; set; }

    public long AssetId { get; set; }

    public string Title { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string Content { get; set; } = null!;

    public long Ordering { get; set; }

    public string Position { get; set; } = null!;

    public int CheckedOut { get; set; }

    public DateTime CheckedOutTime { get; set; }

    public DateTime PublishUp { get; set; }

    public DateTime PublishDown { get; set; }

    public short Published { get; set; }

    public string? Module { get; set; }

    public long Access { get; set; }

    public short Showtitle { get; set; }

    public string Params { get; set; } = null!;

    public short ClientId { get; set; }

    public string Language { get; set; } = null!;
}
