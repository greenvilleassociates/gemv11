using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HFinderType
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Mime { get; set; } = null!;
}
