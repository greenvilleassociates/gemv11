using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gvendor
{
    public int Id { get; set; }

    public string? Vendorid { get; set; }

    public string? Vendorname { get; set; }

    public string? Vendoraddress1 { get; set; }

    public string? Vendoraddress2 { get; set; }

    public string? Vendorcity { get; set; }

    public string? Vendorstate { get; set; }

    public string? Vendorzip { get; set; }
}
