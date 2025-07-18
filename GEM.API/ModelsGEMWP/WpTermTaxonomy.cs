using System;
using System.Collections.Generic;

namespace GEMWP.Models;

public partial class WpTermTaxonomy
{
    public long TermTaxonomyId { get; set; }

    public long TermId { get; set; }

    public string Taxonomy { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long Parent { get; set; }

    public long Count { get; set; }
}
