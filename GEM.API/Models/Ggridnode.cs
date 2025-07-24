using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Ggridnode
{
    public int Id { get; set; }

    public int? Siteid { get; set; }

    public int? Rackid { get; set; }

    public int? Locationid { get; set; }

    public int? Floorid { get; set; }

    public string? Ipaddress { get; set; }

    public string? Telemetryip { get; set; }

    public int? Rootid1 { get; set; }

    public int? Rootid2 { get; set; }
}
