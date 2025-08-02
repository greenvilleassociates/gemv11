using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gworktype
{
    public int Id { get; set; }

    public int Worktypeid { get; set; }

    public string? Description { get; set; }
}
