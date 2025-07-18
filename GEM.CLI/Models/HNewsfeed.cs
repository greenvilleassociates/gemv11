using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HNewsfeed
{
    public long Catid { get; set; }

    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public string Link { get; set; } = null!;

    public short Published { get; set; }

    public long Numarticles { get; set; }

    public long CacheTime { get; set; }

    public int CheckedOut { get; set; }

    public DateTime CheckedOutTime { get; set; }

    public long Ordering { get; set; }

    public short Rtl { get; set; }

    public long Access { get; set; }

    public string Language { get; set; } = null!;

    public string Params { get; set; } = null!;

    public DateTime Created { get; set; }

    public int CreatedBy { get; set; }

    public string CreatedByAlias { get; set; } = null!;

    public DateTime Modified { get; set; }

    public int ModifiedBy { get; set; }

    public string Metakey { get; set; } = null!;

    public string Metadesc { get; set; } = null!;

    public string Metadata { get; set; } = null!;

    /// <summary>
    /// A reference to enable linkages to external data sets.
    /// </summary>
    public string Xreference { get; set; } = null!;

    public DateTime PublishUp { get; set; }

    public DateTime PublishDown { get; set; }

    public string Description { get; set; } = null!;

    public long Version { get; set; }

    public long Hits { get; set; }

    public string Images { get; set; } = null!;
}
