using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HContactDetail
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public string? ConPosition { get; set; }

    public string? Address { get; set; }

    public string? Suburb { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Postcode { get; set; }

    public string? Telephone { get; set; }

    public string? Fax { get; set; }

    public string? Misc { get; set; }

    public string? Image { get; set; }

    public string? EmailTo { get; set; }

    public short DefaultCon { get; set; }

    public short Published { get; set; }

    public long CheckedOut { get; set; }

    public DateTime CheckedOutTime { get; set; }

    public long Ordering { get; set; }

    public string Params { get; set; } = null!;

    public long UserId { get; set; }

    public long Catid { get; set; }

    public long Access { get; set; }

    public string Mobile { get; set; } = null!;

    public string Webpage { get; set; } = null!;

    public string Sortname1 { get; set; } = null!;

    public string Sortname2 { get; set; } = null!;

    public string Sortname3 { get; set; } = null!;

    public string Language { get; set; } = null!;

    public DateTime Created { get; set; }

    public int CreatedBy { get; set; }

    public string CreatedByAlias { get; set; } = null!;

    public DateTime Modified { get; set; }

    public int ModifiedBy { get; set; }

    public string Metakey { get; set; } = null!;

    public string Metadesc { get; set; } = null!;

    public string Metadata { get; set; } = null!;

    /// <summary>
    /// Set if contact is featured.
    /// </summary>
    public short Featured { get; set; }

    /// <summary>
    /// A reference to enable linkages to external data sets.
    /// </summary>
    public string Xreference { get; set; } = null!;

    public DateTime PublishUp { get; set; }

    public DateTime PublishDown { get; set; }

    public long Version { get; set; }

    public long Hits { get; set; }
}
