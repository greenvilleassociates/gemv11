using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HFinderTokensAggregate
{
    public int TermId { get; set; }

    public string MapSuffix { get; set; } = null!;

    public string Term { get; set; } = null!;

    public string Stem { get; set; } = null!;

    public short Common { get; set; }

    public short Phrase { get; set; }

    public decimal TermWeight { get; set; }

    public short Context { get; set; }

    public decimal ContextWeight { get; set; }

    public decimal TotalWeight { get; set; }

    public string Language { get; set; } = null!;
}
