using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Grouter
{
    public int Id { get; set; }

    public string? Routerid { get; set; }

    public string? Description { get; set; }

    public string? Ipaddress { get; set; }

    public string? Telemetryipaddress { get; set; }

    public string? Vpnid1 { get; set; }

    public string? Vpnid2 { get; set; }

    public string? Inventoryid { get; set; }

    public string? Region { get; set; }

    public string? Siteid { get; set; }

    public int? Instanceid { get; set; }

    public int? Custid { get; set; }

    public string? Serialnumber { get; set; }
}
