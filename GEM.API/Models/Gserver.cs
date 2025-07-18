using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gserver
{
    public int Id { get; set; }

    public string? Serverid { get; set; }

    public string? Description { get; set; }

    public string? Ipaddress { get; set; }

    public string? Telemetryipaddress { get; set; }

    public string? Vpnid1 { get; set; }

    public string? Vpnid2 { get; set; }

    public string? Inventoryid { get; set; }
}
