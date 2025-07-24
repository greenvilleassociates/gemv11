using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gcountry
{
    public int Id { get; set; }

    public string? Countryid { get; set; }

    public string? Exchange { get; set; }

    public string? Region { get; set; }

    public string? Description { get; set; }
}
