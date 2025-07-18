using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Ginventory
{
    public int Id { get; set; }

    public string? Inventoryid { get; set; }

    public int? Inventorytype { get; set; }

    public string? Description { get; set; }

    public string? Serialnumber { get; set; }
}
