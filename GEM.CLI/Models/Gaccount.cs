using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gaccount
{
    public long Id { get; set; }

    public string? Accountname { get; set; }

    public int? Companyid { get; set; }

    public int? Wholesalevendorid { get; set; }
}
