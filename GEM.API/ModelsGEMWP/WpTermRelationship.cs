using System;
using System.Collections.Generic;

namespace GEMWP.Models;

public partial class WpTermRelationship
{
    public long ObjectId { get; set; }

    public long TermTaxonomyId { get; set; }

    public int TermOrder { get; set; }
}
