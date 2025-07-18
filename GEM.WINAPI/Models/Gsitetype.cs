using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gsitetype
{
    public int Id { get; set; }

    public int? Sitetypeid { get; set; }

    public string? Description { get; set; }
}
