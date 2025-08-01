using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gfirewall
{
    public int Id { get; set; }

    public string? Firewallid { get; set; }

    public string? Description { get; set; }

    public string? Ipaddress { get; set; }

    public string? Telemetryipaddress { get; set; }

    public string? Vpnid1 { get; set; }

    public string? Vpnid2 { get; set; }

    public string? Inventoryid { get; set; }

    public int? Instanceid { get; set; }

    public int? Custid { get; set; }

    public string? Serialnumber { get; set; }

    public int? Regionid { get; set; }

    public int? Siteid { get; set; }
}
