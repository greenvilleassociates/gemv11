using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Grack
{
    public int Id { get; set; }

    public string? Siteid { get; set; }

    public string? Region { get; set; }

    public string? Floor { get; set; }

    public string? Description { get; set; }

    public string? Suite { get; set; }
}
