using System;
using System.Collections.Generic;

namespace CE.MYSQLMODELS;

public partial class Testpost
{
    public int PostId { get; set; }

    public int? UserId { get; set; }

    public string Title { get; set; } = null!;

    public string? Content { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Testuser? User { get; set; }
}
