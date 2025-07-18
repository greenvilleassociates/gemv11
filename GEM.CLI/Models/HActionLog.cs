using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HActionLog
{
    public int Id { get; set; }

    public string MessageLanguageKey { get; set; } = null!;

    public string Message { get; set; } = null!;

    public DateTime LogDate { get; set; }

    public string Extension { get; set; } = null!;

    public int UserId { get; set; }

    public int ItemId { get; set; }

    public string IpAddress { get; set; } = null!;
}
