using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gvolume
{
    public int Id { get; set; }

    public string? Volumeid { get; set; }

    public int? Volumetype { get; set; }

    public int? Diskid { get; set; }

    public string? Description { get; set; }

    public string? Inventoryid { get; set; }
}
