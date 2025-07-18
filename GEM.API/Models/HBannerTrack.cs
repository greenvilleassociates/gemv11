using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HBannerTrack
{
    public DateTime TrackDate { get; set; }

    public long TrackType { get; set; }

    public long BannerId { get; set; }

    public long Count { get; set; }
}
