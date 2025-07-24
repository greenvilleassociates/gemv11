using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Ghostimage
{
    public int Id { get; set; }

    public string? Imageid { get; set; }

    public string? Description { get; set; }

    public string? Imageurl { get; set; }

    public string? Imagevendor { get; set; }

    public string? Vendoraccountid { get; set; }

    public string? Operatingsystem { get; set; }

    public string? Inventoryid { get; set; }
}
