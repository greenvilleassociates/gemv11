using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gnetworksplicebox
{
    public int Id { get; set; }

    public long? Spliceid { get; set; }

    public string? Description { get; set; }

    public string? Gpslat { get; set; }

    public string? Gpslong { get; set; }

    public string? User1 { get; set; }

    public string? User2 { get; set; }

    public string? User3 { get; set; }

    public string? User4 { get; set; }

    public string? User5 { get; set; }

    public string? Inventoryid { get; set; }
}
