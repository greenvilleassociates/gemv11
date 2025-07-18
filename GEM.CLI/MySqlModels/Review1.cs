using System;
using System.Collections.Generic;

namespace CE.MYSQLMODELS;

public partial class Review1
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int Rating { get; set; }

    public string? Description { get; set; }

    public int MovieId { get; set; }

    public virtual Movie Movie { get; set; } = null!;
}
