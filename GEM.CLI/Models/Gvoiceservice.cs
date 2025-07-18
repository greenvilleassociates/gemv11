using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gvoiceservice
{
    public int Id { get; set; }

    public int? Networkid { get; set; }

    public string? Voiceserviceid { get; set; }

    public string? Description { get; set; }

    public string? Inventoryid { get; set; }
}
