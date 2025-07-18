using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HContent
{
    public int Id { get; set; }

    /// <summary>
    /// FK to the #__assets table.
    /// </summary>
    public long AssetId { get; set; }

    public string Title { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public string Introtext { get; set; } = null!;

    public string Fulltext { get; set; } = null!;

    public short State { get; set; }

    public long Catid { get; set; }

    public DateTime Created { get; set; }

    public long CreatedBy { get; set; }

    public string CreatedByAlias { get; set; } = null!;

    public DateTime Modified { get; set; }

    public long ModifiedBy { get; set; }

    public long CheckedOut { get; set; }

    public DateTime CheckedOutTime { get; set; }

    public DateTime PublishUp { get; set; }

    public DateTime PublishDown { get; set; }

    public string Images { get; set; } = null!;

    public string Urls { get; set; } = null!;

    public string Attribs { get; set; } = null!;

    public long Version { get; set; }

    public long Ordering { get; set; }

    public string Metakey { get; set; } = null!;

    public string Metadesc { get; set; } = null!;

    public long Access { get; set; }

    public long Hits { get; set; }

    public string Metadata { get; set; } = null!;

    /// <summary>
    /// Set if article is featured.
    /// </summary>
    public short Featured { get; set; }

    /// <summary>
    /// The language code for the article.
    /// </summary>
    public string Language { get; set; } = null!;

    /// <summary>
    /// A reference to enable linkages to external data sets.
    /// </summary>
    public string Xreference { get; set; } = null!;

    public string Note { get; set; } = null!;
}
