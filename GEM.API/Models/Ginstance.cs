using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Ginstance
{
    public int Id { get; set; }

    public string? Custid { get; set; }

    public string? Ncrid { get; set; }

    public string? Dynamicsid { get; set; }

    public string? Oracleid { get; set; }

    public int? Buscontactid { get; set; }

    public string? Techcontactid { get; set; }

    public string? Techcontactemail { get; set; }
}
