using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HTemplateStyle
{
    public int Id { get; set; }

    public string Template { get; set; } = null!;

    public short ClientId { get; set; }

    public string Home { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Params { get; set; } = null!;
}
