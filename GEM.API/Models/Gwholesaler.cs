using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gwholesaler
{
    public long Id { get; set; }

    public string? Wholesalename { get; set; }

    public int? Companyid { get; set; }

    public string? Dynamicsid { get; set; }

    public string? Oracleid { get; set; }

    public string? Alohaid { get; set; }
}
