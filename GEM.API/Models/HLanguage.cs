using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HLanguage
{
    public int LangId { get; set; }

    public long AssetId { get; set; }

    public string LangCode { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string TitleNative { get; set; } = null!;

    public string Sef { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Metakey { get; set; } = null!;

    public string Metadesc { get; set; } = null!;

    public string Sitename { get; set; } = null!;

    public long Published { get; set; }

    public int Access { get; set; }

    public long Ordering { get; set; }
}
