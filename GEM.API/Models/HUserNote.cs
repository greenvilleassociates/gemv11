using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HUserNote
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int Catid { get; set; }

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public short State { get; set; }

    public int CheckedOut { get; set; }

    public DateTime CheckedOutTime { get; set; }

    public int CreatedUserId { get; set; }

    public DateTime CreatedTime { get; set; }

    public int ModifiedUserId { get; set; }

    public DateTime ModifiedTime { get; set; }

    public DateTime ReviewTime { get; set; }

    public DateTime PublishUp { get; set; }

    public DateTime PublishDown { get; set; }
}
