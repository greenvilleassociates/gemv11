using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gphysicalpar
{
    public int Id { get; set; }

    public int? Siteid { get; set; }

    public string? Description { get; set; }

    public string? Inventoryid { get; set; }
}
