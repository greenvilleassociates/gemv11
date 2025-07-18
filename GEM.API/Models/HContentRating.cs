using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HContentRating
{
    public long ContentId { get; set; }

    public long RatingSum { get; set; }

    public long RatingCount { get; set; }

    public string Lastip { get; set; } = null!;
}
