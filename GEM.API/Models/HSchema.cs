using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HSchema
{
    public long ExtensionId { get; set; }

    public string VersionId { get; set; } = null!;
}
