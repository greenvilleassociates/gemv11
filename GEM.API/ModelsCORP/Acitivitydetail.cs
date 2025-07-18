using System;
using System.Collections.Generic;

namespace GEMAPI.ModelsCORP;

public partial class Acitivitydetail
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public string? Startdate { get; set; }

    public string? Enddate { get; set; }

    public string? Certauthority { get; set; }

    public string? Status { get; set; }

    public string? Emplid { get; set; }

    public string? Location { get; set; }

    public int? Userid { get; set; }

    public int? Employee { get; set; }

    public string? Fullname { get; set; }
}
