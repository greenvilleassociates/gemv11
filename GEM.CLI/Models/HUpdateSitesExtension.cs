using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

/// <summary>
/// Links extensions to update sites
/// </summary>
public partial class HUpdateSitesExtension
{
    public long UpdateSiteId { get; set; }

    public long ExtensionId { get; set; }
}
