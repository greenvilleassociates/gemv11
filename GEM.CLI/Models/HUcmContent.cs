using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HUcmContent
{
    public int CoreContentId { get; set; }

    public string CoreTypeAlias { get; set; } = null!;

    public string CoreTitle { get; set; } = null!;

    public string CoreAlias { get; set; } = null!;

    public string CoreBody { get; set; } = null!;

    public short CoreState { get; set; }

    public DateTime CoreCheckedOutTime { get; set; }

    public long CoreCheckedOutUserId { get; set; }

    public long CoreAccess { get; set; }

    public string CoreParams { get; set; } = null!;

    public short CoreFeatured { get; set; }

    public string CoreMetadata { get; set; } = null!;

    public long CoreCreatedUserId { get; set; }

    public string CoreCreatedByAlias { get; set; } = null!;

    public DateTime CoreCreatedTime { get; set; }

    public long CoreModifiedUserId { get; set; }

    public DateTime CoreModifiedTime { get; set; }

    public string CoreLanguage { get; set; } = null!;

    public DateTime CorePublishUp { get; set; }

    public DateTime CorePublishDown { get; set; }

    public long CoreContentItemId { get; set; }

    public long AssetId { get; set; }

    public string CoreImages { get; set; } = null!;

    public string CoreUrls { get; set; } = null!;

    public long CoreHits { get; set; }

    public long CoreVersion { get; set; }

    public long CoreOrdering { get; set; }

    public string CoreMetakey { get; set; } = null!;

    public string CoreMetadesc { get; set; } = null!;

    public long CoreCatid { get; set; }

    public string CoreXreference { get; set; } = null!;

    public long CoreTypeId { get; set; }
}
