using System;
using System.Collections.Generic;

namespace CE.MYSQLMODELS;

public partial class Testuser
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Testpost> Testposts { get; set; } = new List<Testpost>();
}
