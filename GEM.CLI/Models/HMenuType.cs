using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HMenuType
{
    public int Id { get; set; }

    public long AssetId { get; set; }

    public string Menutype { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ClientId { get; set; }
}
