using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gdbmsrelease
{
    public int Id { get; set; }

    public string? Vendorname { get; set; }

    public string? Vendorid { get; set; }

    public string? Releasedescription { get; set; }

    public string? Releaseversion { get; set; }

    public string? Releasesystemrequirements { get; set; }
}
