using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HFinderToken
{
    public string Term { get; set; } = null!;

    public string Stem { get; set; } = null!;

    public short Common { get; set; }

    public short Phrase { get; set; }

    public decimal Weight { get; set; }

    public short Context { get; set; }

    public string Language { get; set; } = null!;
}
