using System;
using System.Collections.Generic;

namespace GEMAPI.Models;

public partial class Gsite
{
    public int Id { get; set; }

    public string? Siteid { get; set; }

    public string? Sitedescription { get; set; }

    public string? Siteclli { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Stateregion { get; set; }

    public string? Postal { get; set; }

    public string? Phone { get; set; }

    public string? Fax { get; set; }

    public int? Sitecontactid { get; set; }

    public string? Cllicode { get; set; }

    public string? Instanceid { get; set; }

    public string? Custid { get; set; }

    public int? Region { get; set; }
}
