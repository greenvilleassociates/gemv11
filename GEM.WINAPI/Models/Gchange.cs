using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gchange
{
    public int Id { get; set; }

    public long? Changeid { get; set; }

    public string? Workeffortsize { get; set; }

    public string? Busunit { get; set; }

    public string? Engineerid { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? Approvalid { get; set; }

    public DateOnly? Changestart { get; set; }

    public DateOnly? Changeend { get; set; }

    public string? Holdinfo { get; set; }

    public string? Comments { get; set; }
}
