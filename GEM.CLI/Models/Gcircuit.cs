using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gcircuit
{
    public int Id { get; set; }

    public int? Circuittypeid { get; set; }

    public string? Description { get; set; }

    public string? Aloc { get; set; }

    public string? Zloc { get; set; }

    public string? Inventoryid { get; set; }
}
