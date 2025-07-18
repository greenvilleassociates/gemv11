using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

/// <summary>
/// Simple user profile storage table
/// </summary>
public partial class HUserProfile
{
    public long UserId { get; set; }

    public string ProfileKey { get; set; } = null!;

    public string ProfileValue { get; set; } = null!;

    public long Ordering { get; set; }
}
