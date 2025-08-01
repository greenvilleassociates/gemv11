using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gserviceorderdetail
{
    public long Id { get; set; }

    public int? Skuid { get; set; }

    public string? Skuidc { get; set; }

    public string? Listcost { get; set; }

    public string? Unitcost { get; set; }

    public string? Statetax { get; set; }

    public string? Federalvat { get; set; }
}
