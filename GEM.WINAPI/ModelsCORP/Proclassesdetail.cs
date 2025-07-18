using System;
using System.Collections.Generic;

namespace GEMAPI.ModelsCORP;

public partial class Proclassesdetail
{
    public int Id { get; set; }

    public string? Classid { get; set; }

    public string? Vendorid { get; set; }

    public int? Instructorid { get; set; }

    public int? Trainsiteid { get; set; }

    public string? Technicalcontactname { get; set; }

    public string? Technicalcontactemail { get; set; }

    public string? Technicalcontactphone { get; set; }

    public string? Providername { get; set; }

    public string? Description { get; set; }

    public DateOnly? Startdate { get; set; }

    public DateOnly? Enddate { get; set; }

    public string? Comments { get; set; }
}
