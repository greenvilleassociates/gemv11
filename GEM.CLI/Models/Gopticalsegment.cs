using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gopticalsegment
{
    public int Id { get; set; }

    public int? Segmenttypeid { get; set; }

    public string? Description { get; set; }

    public string? Aloc { get; set; }

    public string? Zloc { get; set; }

    public string? Inventoryid { get; set; }
}
