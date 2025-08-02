using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gopticalring
{
    public int Id { get; set; }

    public string? Ringid { get; set; }

    public int? Ringtype { get; set; }

    public int? Siteid1 { get; set; }

    public int? Siteid2 { get; set; }

    public int? Siteid3 { get; set; }

    public int? Siteid4 { get; set; }

    public int? Siteid5 { get; set; }

    public int? Vendorid { get; set; }

    public string? Description { get; set; }

    public string? Ipaddress { get; set; }

    public string? Telemetryipaddress { get; set; }

    public string? Vpnid1 { get; set; }

    public string? Vpnid2 { get; set; }

    public string? Lat { get; set; }

    public string? Long { get; set; }

    public string? Inventoryid { get; set; }
}
