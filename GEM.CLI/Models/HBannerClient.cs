using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HBannerClient
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Extrainfo { get; set; } = null!;

    public short State { get; set; }

    public long CheckedOut { get; set; }

    public DateTime CheckedOutTime { get; set; }

    public string Metakey { get; set; } = null!;

    public short OwnPrefix { get; set; }

    public string MetakeyPrefix { get; set; } = null!;

    public short PurchaseType { get; set; }

    public short TrackClicks { get; set; }

    public short TrackImpressions { get; set; }
}
