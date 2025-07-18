using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HUsergroup
{
    /// <summary>
    /// Primary Key
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Adjacency List Reference Id
    /// </summary>
    public long ParentId { get; set; }

    /// <summary>
    /// Nested set lft.
    /// </summary>
    public long Lft { get; set; }

    /// <summary>
    /// Nested set rgt.
    /// </summary>
    public long Rgt { get; set; }

    public string Title { get; set; } = null!;
}
