using System;
using System.Collections.Generic;

namespace GEMWP.Models;

public partial class WpTerm
{
    public long TermId { get; set; }

    public string Name { get; set; } = null!;

    public string Slug { get; set; } = null!;

    public long TermGroup { get; set; }
}
