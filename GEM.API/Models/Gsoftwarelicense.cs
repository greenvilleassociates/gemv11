using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gsoftwarelicense
{
    public int Id { get; set; }

    public string? Licenseid { get; set; }

    public string? Description { get; set; }

    public int? Licensetypeid { get; set; }

    public int? Vendorid { get; set; }

    public DateOnly? Startdate { get; set; }

    public DateOnly? Enddate { get; set; }

    public DateOnly? Notificationdate { get; set; }

    public string? Alertemail { get; set; }

    public int? Technicalcontactid { get; set; }

    public int? Gridid { get; set; }

    public int? Totalseats { get; set; }
}
