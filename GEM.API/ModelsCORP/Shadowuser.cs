using System;
using System.Collections.Generic;

namespace GEMAPI.ModelsCORP;

public partial class Shadowuser
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public DateOnly? Registerdate { get; set; }

    public string? Params { get; set; }
}
