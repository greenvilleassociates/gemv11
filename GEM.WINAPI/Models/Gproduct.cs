using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gproduct
{
    public int Id { get; set; }

    public int? Productid { get; set; }

    public string? Productname { get; set; }

    public string? ProductWooId { get; set; }

    public string? ProudctWooInstance { get; set; }

    public string? ProductWooUrl { get; set; }

    public string? Vendorid { get; set; }

    public string? Oracleid { get; set; }

    public string? Dynamicsid { get; set; }

    public string? Division { get; set; }
}
