using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HOverrider
{
    /// <summary>
    /// Primary Key
    /// </summary>
    public int Id { get; set; }

    public string Constant { get; set; } = null!;

    public string String { get; set; } = null!;

    public string File { get; set; } = null!;
}
