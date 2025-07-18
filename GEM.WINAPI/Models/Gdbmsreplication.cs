using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gdbmsreplication
{
    public int Id { get; set; }

    public string? Vendorname { get; set; }

    public string? Vendorid { get; set; }

    public string? Replicationdescription { get; set; }
}
