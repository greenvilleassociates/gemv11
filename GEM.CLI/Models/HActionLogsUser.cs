using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HActionLogsUser
{
    public int UserId { get; set; }

    public int Notify { get; set; }

    public string Extensions { get; set; } = null!;
}
