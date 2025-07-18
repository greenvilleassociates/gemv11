using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Ggridroot
{
    public int Id { get; set; }

    public int? Siteid { get; set; }

    public int? Rackid { get; set; }

    public int? Locationid { get; set; }

    public int? Floorid { get; set; }

    public string? Ipaddress { get; set; }

    public string? Telemetryip { get; set; }

    public string? Region { get; set; }

    public string? Gridid { get; set; }
}
