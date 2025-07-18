using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HFinderTaxonomy
{
    public int Id { get; set; }

    public int ParentId { get; set; }

    public string Title { get; set; } = null!;

    public short State { get; set; }

    public short Access { get; set; }

    public short Ordering { get; set; }
}
