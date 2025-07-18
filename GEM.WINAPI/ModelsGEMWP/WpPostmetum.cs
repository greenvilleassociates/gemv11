using System;
using System.Collections.Generic;

namespace GEMWP.Models;

public partial class WpPostmetum
{
    public long MetaId { get; set; }

    public long PostId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
