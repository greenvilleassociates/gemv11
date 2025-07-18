using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HPrivacyConsent
{
    public int Id { get; set; }

    public long UserId { get; set; }

    public short State { get; set; }

    public DateTime Created { get; set; }

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public short Remind { get; set; }

    public string Token { get; set; } = null!;
}
