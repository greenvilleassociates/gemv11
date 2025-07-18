using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HBanner
{
    public int Id { get; set; }

    public long Cid { get; set; }

    public long Type { get; set; }

    public string Name { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public long Imptotal { get; set; }

    public long Impmade { get; set; }

    public long Clicks { get; set; }

    public string Clickurl { get; set; } = null!;

    public short State { get; set; }

    public long Catid { get; set; }

    public string Description { get; set; } = null!;

    public string Custombannercode { get; set; } = null!;

    public short Sticky { get; set; }

    public long Ordering { get; set; }

    public string Metakey { get; set; } = null!;

    public string Params { get; set; } = null!;

    public short OwnPrefix { get; set; }

    public string MetakeyPrefix { get; set; } = null!;

    public short PurchaseType { get; set; }

    public short TrackClicks { get; set; }

    public short TrackImpressions { get; set; }

    public long CheckedOut { get; set; }

    public DateTime CheckedOutTime { get; set; }

    public DateTime PublishUp { get; set; }

    public DateTime PublishDown { get; set; }

    public DateTime Reset { get; set; }

    public DateTime Created { get; set; }

    public string Language { get; set; } = null!;

    public long CreatedBy { get; set; }

    public string CreatedByAlias { get; set; } = null!;

    public DateTime Modified { get; set; }

    public long ModifiedBy { get; set; }

    public long Version { get; set; }
}
