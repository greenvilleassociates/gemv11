using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HViewlevel
{
    /// <summary>
    /// Primary Key
    /// </summary>
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public long Ordering { get; set; }

    /// <summary>
    /// JSON encoded access control.
    /// </summary>
    public string Rules { get; set; } = null!;
}
