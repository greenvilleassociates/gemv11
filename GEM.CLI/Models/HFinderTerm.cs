using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HFinderTerm
{
    public int TermId { get; set; }

    public string Term { get; set; } = null!;

    public string Stem { get; set; } = null!;

    public short Common { get; set; }

    public short Phrase { get; set; }

    public decimal Weight { get; set; }

    public string Soundex { get; set; } = null!;

    public int Links { get; set; }

    public string Language { get; set; } = null!;
}
