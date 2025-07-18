using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gvoicetrunk
{
    public int Id { get; set; }

    public string? Trunkid { get; set; }

    public int? Trunktypeid { get; set; }

    public string? Description { get; set; }

    public string? Inventoryid { get; set; }
}
