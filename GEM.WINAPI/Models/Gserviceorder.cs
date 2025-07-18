using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gserviceorder
{
    public int Id { get; set; }

    public string? Regiondescription { get; set; }

    public int? Regionid { get; set; }

    public int? Ordertype { get; set; }

    public string? Custid { get; set; }

    public string? Orderdescription { get; set; }

    public int? Totalitems { get; set; }
}
