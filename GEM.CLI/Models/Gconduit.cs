using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gconduit
{
    public int Id { get; set; }

    public string? Conduitid { get; set; }

    public int? Conduittype { get; set; }

    public int? Rowid { get; set; }

    public string? Description { get; set; }

    public string? Inventoryid { get; set; }
}
