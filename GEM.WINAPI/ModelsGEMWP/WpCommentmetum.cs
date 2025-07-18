using System;
using System.Collections.Generic;

namespace GEMWP.Models;

public partial class WpCommentmetum
{
    public long MetaId { get; set; }

    public long CommentId { get; set; }

    public string? MetaKey { get; set; }

    public string? MetaValue { get; set; }
}
