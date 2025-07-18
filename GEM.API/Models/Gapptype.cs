using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gapptype
{
    public int Id { get; set; }

    public int? Apptype { get; set; }

    public string? Apptypedescription { get; set; }
}
