using System;
using System.Collections.Generic;

namespace GEMWP.Models;

public partial class WpTermmetum
{
    public long MetaId { get; set; }

    public long TermId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
