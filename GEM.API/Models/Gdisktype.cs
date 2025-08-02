using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gdisktype
{
    public int Id { get; set; }

    public int? Disktype { get; set; }

    public string? Description { get; set; }

    public string? Vendorid { get; set; }
}
