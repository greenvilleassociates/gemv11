using System;
using System.Collections.Generic;

namespace GEMAPI.ModelsCORP;

public partial class Companyannouncements
{
    public int Id { get; set; }

    public string? Annid { get; set; }

    public string? Description { get; set; }

    public DateOnly? Startdate { get; set; }

    public DateOnly? Enddate { get; set; }
}
