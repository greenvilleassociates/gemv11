using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HUserKey
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Token { get; set; } = null!;

    public string Series { get; set; } = null!;

    public short Invalid { get; set; }

    public string Time { get; set; } = null!;

    public string Uastring { get; set; } = null!;
}
