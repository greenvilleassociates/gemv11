using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gnetwork
{
    public int Id { get; set; }

    public int? Networkid { get; set; }

    public int? Networktypeid { get; set; }

    public string? Description { get; set; }

    public string? Inventoryid { get; set; }
}
