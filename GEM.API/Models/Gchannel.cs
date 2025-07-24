using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gchannel
{
    public int Id { get; set; }

    public int? Channelid { get; set; }

    public string? Circuitid { get; set; }

    public string? Description { get; set; }

    public string? Inventoryid { get; set; }
}
