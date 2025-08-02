using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gserviceordertype
{
    public int Id { get; set; }

    public string? Servicetypedescription { get; set; }

    public int? Servicetypeid { get; set; }
}
