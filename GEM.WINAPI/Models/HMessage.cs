using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HMessage
{
    public int MessageId { get; set; }

    public long UserIdFrom { get; set; }

    public long UserIdTo { get; set; }

    public short FolderId { get; set; }

    public DateTime DateTime { get; set; }

    public short State { get; set; }

    public short Priority { get; set; }

    public string Subject { get; set; } = null!;

    public string Message { get; set; } = null!;
}
