using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HCoreLogSearch
{
    public string SearchTerm { get; set; } = null!;

    public long Hits { get; set; }
}
