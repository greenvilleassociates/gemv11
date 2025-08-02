using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gitsm
{
    public long Id { get; set; }

    public long? Ticketid { get; set; }

    public string? Custid { get; set; }

    public string? Oracleid { get; set; }

    public string? Dynamicsid { get; set; }

    public string? Summary { get; set; }

    public string? Priority { get; set; }

    public string? Res1 { get; set; }

    public string? Res2 { get; set; }

    public string? Res3 { get; set; }

    public string? Res4 { get; set; }

    public string? Ticketstatus { get; set; }

    public DateOnly? Opendate { get; set; }

    public DateOnly? Closedate { get; set; }
}
