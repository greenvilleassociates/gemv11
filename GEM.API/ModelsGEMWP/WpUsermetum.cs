using System;
using System.Collections.Generic;

namespace GEMWP.Models;

public partial class WpUsermetum
{
    public long UmetaId { get; set; }

    public long UserId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
