using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Glicensetype
{
    public int Id { get; set; }

    public int? Licensetypeid { get; set; }

    public string? Description { get; set; }

    public string? Term { get; set; }
}
