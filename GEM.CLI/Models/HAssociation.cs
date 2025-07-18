using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HAssociation
{
    /// <summary>
    /// A reference to the associated item.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The context of the associated item.
    /// </summary>
    public string Context { get; set; } = null!;

    /// <summary>
    /// The key for the association computed from an md5 on associated ids.
    /// </summary>
    public string Key { get; set; } = null!;
}
