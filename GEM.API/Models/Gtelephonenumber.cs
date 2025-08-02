using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gtelephonenumber
{
    public int Id { get; set; }

    public string? Tn { get; set; }

    public int? Phoneid { get; set; }

    public int? Channelid { get; set; }

    public string? Description { get; set; }

    public string? Inventoryid { get; set; }
}
