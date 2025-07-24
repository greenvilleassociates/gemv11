using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class TriggerLog
{
    public int Id { get; set; }

    public DateTime? EventTime { get; set; }

    public string? TableName { get; set; }

    public string? TriggerName { get; set; }

    public string? Operation { get; set; }

    public string? UserName { get; set; }
}
