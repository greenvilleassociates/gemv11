using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class HSession
{
    public byte[] SessionId { get; set; } = null!;

    public short? ClientId { get; set; }

    public short? Guest { get; set; }

    public int Time { get; set; }

    public string? Data { get; set; }

    public long? Userid { get; set; }

    public string? Username { get; set; }
}
