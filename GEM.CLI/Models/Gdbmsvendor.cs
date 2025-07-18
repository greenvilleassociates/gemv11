using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gdbmsvendor
{
    public int Id { get; set; }

    public string? Vendorname { get; set; }

    public string? Vendorid { get; set; }

    public string? Dynamicsid { get; set; }

    public string? Oracleid { get; set; }
}
