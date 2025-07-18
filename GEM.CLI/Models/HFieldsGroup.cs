using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HFieldsGroup
{
    public int Id { get; set; }

    public long AssetId { get; set; }

    public string Context { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string Description { get; set; } = null!;

    public short State { get; set; }

    public int CheckedOut { get; set; }

    public DateTime CheckedOutTime { get; set; }

    public int Ordering { get; set; }

    public string Params { get; set; } = null!;

    public string Language { get; set; } = null!;

    public DateTime Created { get; set; }

    public long CreatedBy { get; set; }

    public DateTime Modified { get; set; }

    public long ModifiedBy { get; set; }

    public long Access { get; set; }
}
