using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HTag
{
    public int Id { get; set; }

    public long ParentId { get; set; }

    public long Lft { get; set; }

    public long Rgt { get; set; }

    public int Level { get; set; }

    public string Path { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Alias { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string Description { get; set; } = null!;

    public short Published { get; set; }

    public long CheckedOut { get; set; }

    public DateTime CheckedOutTime { get; set; }

    public long Access { get; set; }

    public string Params { get; set; } = null!;

    public string Metadesc { get; set; } = null!;

    public string Metakey { get; set; } = null!;

    public string Metadata { get; set; } = null!;

    public int CreatedUserId { get; set; }

    public DateTime CreatedTime { get; set; }

    public string CreatedByAlias { get; set; } = null!;

    public int ModifiedUserId { get; set; }

    public DateTime ModifiedTime { get; set; }

    public string Images { get; set; } = null!;

    public string Urls { get; set; } = null!;

    public int Hits { get; set; }

    public string Language { get; set; } = null!;

    public long Version { get; set; }

    public DateTime PublishUp { get; set; }

    public DateTime PublishDown { get; set; }
}
